using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class GunController : MonoBehaviour
{
    
    public float bulletSpeed;
    public float cooldown;
    private float shotCounter;
    public bool isFiring = true;
    public BulletController bullet;
    //public FreezeBullet freezeBullet;

    //public Transform Bullet;
    public Transform firePoint;
    public AudioClip smgSound;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Shoot();
        if (isFiring)
        {
            shotCounter -= Time.deltaTime;
            if (shotCounter <= 0)
            {
                shotCounter = cooldown;
                BulletController newBullet = Instantiate(bullet, firePoint.position, firePoint.rotation) as BulletController;
                //FreezeBullet newFreezeBullet = Instantiate(freezeBullet, firePoint.position, firePoint.rotation) as FreezeBullet;
                //newFreezeBullet.speed = bulletSpeed;

                newBullet.speed = bulletSpeed;

            }
        }
        else
        {
            shotCounter = 0;
        }
        //if (Input.GetMouseButton(0))
        //{
        //    Transform BulletTrans = Instantiate(Bullet, firePoint.position, firePoint.rotation);
        //    Rigidbody BulletRB = BulletTrans.GetComponent<Rigidbody>();
        //    BulletRB.AddRelativeForce(Vector3.forward * bulletSpeed);
        //}
    }

    private void Shoot()
    {
        if (Input.GetMouseButtonDown(0))
        {
            AudioSource.PlayClipAtPoint(smgSound, transform.position);
        }
        if (Input.GetMouseButton(0))
        {
            isFiring = true;
        }
        else
        {
            isFiring = false;
        }
    }
}



using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shotgun : MonoBehaviour
{
    public Transform firePoint;
    public float bulletSpeed;
    private int bulletCount = 6;

    private float pelletFireVel= 700;
    private float spreadAngle = 10;
    public FreezeBullet freezebullet;
    public GameObject[] bullettype;
    //public GameObject bullet;
    List<Quaternion> freezeBullet; // single bullet
    List<Quaternion> shotbullets; // 6 bullet
    private float time = 1.0f;
    private float timer;
    public AudioClip shotgunSound;
    int curBullet = 0;
    // Start is called before the first frame update
    void Awake()
    {
        shotbullets = new List<Quaternion>(new Quaternion[bulletCount]);
        freezeBullet = new List<Quaternion>(new Quaternion[1]);
    }

    // Update is called once per frame
    void Update()
    {
        timer -= Time.deltaTime;
        //press "tab" to switch bullets
        if (Input.GetKey(KeyCode.Tab))
        {
            // Add one to the curBullet variable when the player presses tab. 
            //This will allow you to fire the next bullet in the bullets Array
            curBullet++;
            // If the curBullet is higher than the bullet array length set it back to 0
            if (curBullet > bullettype.Length)
            {
                curBullet = 0;
            }
        }
        if (Input.GetButtonDown("Fire1"))
        {
            if (timer < 0) {
                Shoot();
                AudioSource.PlayClipAtPoint(shotgunSound, transform.position);
                timer = time;
            }
        }

    }
    void Shoot()
    {
        //Instantiate(bullet[curBullet], firePoint.position, firePoint.rotation);
        if (curBullet == 0)
        {
            for (int i = 0; i < 6; i++)
            {
                shotbullets[i] = Random.rotation;
                GameObject p = Instantiate(bullettype[0], firePoint.position, firePoint.rotation);
                Destroy(p, 0.5f);
                p.transform.rotation = Quaternion.RotateTowards(p.transform.rotation, shotbullets[i], spreadAngle);
                p.GetComponent<Rigidbody>().AddForce(p.transform.forward * pelletFireVel);
            }
        }else
        //curBullet == 1
        {
            GameObject f = Instantiate(bullettype[1], firePoint.position, firePoint.rotation);
            f.GetComponent<Rigidbody>().AddForce(f.transform.forward * pelletFireVel);
            //f.speed = bulletSpeed;
            //as FreezeBullet;

        }

    }

}

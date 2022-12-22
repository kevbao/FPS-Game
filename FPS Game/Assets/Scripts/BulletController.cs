using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletController : MonoBehaviour
{
    public float speed;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector3.forward * speed * Time.deltaTime);

        Object.Destroy(gameObject, 1.5f);
    }
    
    void OnCollisionEnter(Collision col)
    {
        if (col.gameObject.tag == "Enemy")
        {
            col.gameObject.GetComponent<EnemyHealth>().currentHealth -= 20;
            Destroy(this.gameObject);
        }
        else
        {
            Destroy(this.gameObject);
        }
        Destroy(gameObject);
        //Destroy(obj.gameObject);
        //if (obj.gameObject.tag == "Enemy")
        //{
        //    Destroy(obj.gameObject);
        //}
    }
}

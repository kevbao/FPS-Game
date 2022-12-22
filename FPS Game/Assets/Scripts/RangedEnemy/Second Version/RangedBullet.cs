using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using UnityEngine;

public class RangedBullet : MonoBehaviour
{
    [SerializeField] private Rigidbody rb;
    [SerializeField] private float launchForce = 50f;
    [SerializeField] private float destroyAfterSeconds = 5f;
    [SerializeField] private float damage = 3f;

    void Start()
    {
        rb.velocity = transform.forward * launchForce;
    }

    // Update is called once per frame
    void Update()
    {
        Destroy(gameObject, destroyAfterSeconds);
    }



    void OnTriggerEnter(Collider other)
    {
        UnityEngine.Debug.Log("hit something");
        if (other.gameObject.tag == "Player")
        {
            /*
            FindObjectOfType<PlayerHealth>().Health -= 3;
            if (FindObjectOfType<PlayerHealth>().Health <= 0)
            {
                FindObjectOfType<PlayerHealth>().GameOver();
            }
            */
            UnityEngine.Debug.Log("hit player");
            other.gameObject.GetComponent<Player_health>().currentHealth -= damage;
            Destroy(this.gameObject);
        }
        else
        {
            Destroy(this.gameObject);
        }
        Destroy(gameObject);

        if (FindObjectOfType<Player_health>().currentHealth <= 0)
        {
            //FindObjectOfType<Player-health>().GameOver();
        }


        /*
        else
        {
            Destroy(this.gameObject);
        }
        
        Destroy(gameObject);
        */
    }
}

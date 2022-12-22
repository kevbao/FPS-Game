
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FreezeBullet : MonoBehaviour
{
    public float speed;
    public EnemyChase obj;
    public Rigidbody m_Rigidbody;
    Vector3 m_YAxis;
    public int freezeTime; // Seconds to freeze
    //private bool Freezing = false; // Is freezing or not
    // Start is called before the first frame update
    void Start()
    {
        m_Rigidbody = gameObject.GetComponent<Rigidbody>();
        m_YAxis = new Vector3(0, 5, 0);
        //Set up vector for moving the Rigidbody in the y axis
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector3.forward * speed * Time.deltaTime);

        Object.Destroy(gameObject, 1.5f);
        //m_Rigidbody = gameObject.GetComponent<Rigidbody>();


    }

    void OnCollisionEnter(Collision obj)
    {
        //Destroy(gameObject);

        if (obj.gameObject.tag == "Enemy")
        {

            Freeze();

        }
    }
    void Freeze()
    {
        //StartCoroutine(CountDown());
  
            //Freeze all positions
            //object reference not set to an instance of an object
            Debug.Log("bullet Freeze activated");
            //EnemyController[] enemies = FindObjectsOfType<EnemyController>();
            //m_Rigidbody.velocity = Vector3.zero;
            //Freeze all positions
            m_Rigidbody.constraints = RigidbodyConstraints.FreezePosition;
            //enemy.GetComponent<EnemyController>().enabled = false;
            //yield return new WaitForSeconds(freezeTime);
            //enemy.GetComponent<Rigidbody3D>().constraints = RigidbodyConstraints3D.None;
            //enemy.GetComponent<EnemyController>().enabled = true;
            Debug.Log("bullet Finish");  

    }
    //m_Rigidbody.constraints = RigidbodyConstraints.None;

    //IEnumerator CountDown()
    //{
    //    while (freezeTime >= 0)  // becarefore this will stuck 
    //    {
    //        //int M = (int)( freezeTime / 60);
    //        //float S = freezeTime % 60;
    //        //countdown1text.GetComponent<Text>().text = string.Format("{0:00}:{1:00}", M, S);
    //        // next screen
    //        yield return new WaitForSeconds(1);
    //        // time countdown
    //        freezeTime--;

    //        // restart the count down
    //        if (freezeTime < 0)
    //        {
    //            freezeTime = 5;
    //        }
    //    }
    //}
}


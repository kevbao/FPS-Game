using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovingPlatform : MonoBehaviour
{
    [SerializeField] private Transform pointA;
    [SerializeField] private Transform pointB;
    [SerializeField] private float speed;
    private float time = 0f;
    private Vector3 offset;
    private bool riding = false;
    private Transform ridingObject;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        Vector3 oldPost = transform.position;
        transform.position = Vector3.Lerp(pointA.position, pointB.position, time);
        time += speed * Time.deltaTime;
        offset = transform.position - oldPost;
        if (time >= 1.0f || time <= 0f)
        {
            if (speed > 0)
                time = 1.0f;
            else
                time = 0f;
            speed *= -1;
        }
        if (riding)
        {
            ridingObject.position += offset;
        }
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            //collision.gameObject.transform.SetParent(transform);
            riding = true;
            ridingObject = collision.gameObject.transform;
        }
    }

    private void OnCollisionExit(Collision collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            //collision.gameObject.transform.SetParent(null);
            riding = false;
            ridingObject = null;
        }
    }
}

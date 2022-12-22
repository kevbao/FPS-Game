using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Timers;

public class Slide : MonoBehaviour
{
    Rigidbody rb;
    CapsuleCollider collider;
    
    private float originalHeight;
    float reducedHeight = 1.0f;

    public float slideSpeed = 10f;
    
    public event System.Action isSliding;
    // Start is called before the first frame update
    void Start()
    {
        collider = GetComponent<CapsuleCollider>();
        rb = GetComponent<Rigidbody>();
        originalHeight = collider.height;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.F) && Input.GetKey(KeyCode.W))
        {
            Sliding();
            isSliding?.Invoke();
            Invoke("GoUp", 0.7f);
        } 

    }
    private void Sliding()
    {
        collider.height = reducedHeight;
        rb.AddForce(transform.forward * slideSpeed, ForceMode.VelocityChange);
    }

    private void GoUp()
    {
        collider.height = originalHeight;
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemPickup : MonoBehaviour
{
    public Item item;
    //public float PickUpRadius = 1f;
    private MeshCollider myCollider;
    // Start is called before the first frame update
    void Start()
    {

        myCollider = GetComponent<MeshCollider>();
        myCollider.isTrigger = true;
        //myCollider. = PickUpRadius;
    }

    // Update is called once per frame
    void Update()
    {
        //if (Input.GetKeyDown("space"))
        //{
        //    Pickup();
        //    print("space key was pressed");

        //}
    }
    //void Pickup()
    //{
    //    InventorySystem.Instance.Add(item);
    //    Destroy(gameObject);
    //}

    private void OnTriggerEnter(Collider other)
    {
        //var inventory = other.transform.GetComponent<Inventory>();
        //if (!inventory) return;
        if(other.CompareTag("Player"))
        {
            InventorySystem.Instance.Add(item);
            Destroy(this.gameObject);
        }

        
    }


}

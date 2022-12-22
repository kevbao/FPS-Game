using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FoodItemMg : MonoBehaviour
{
    public Transform resetPoint;
    public GameObject player;
    public int itemsGotten;
    // Start is called before the first frame update
    void Start()
    {
        itemsGotten = 0;
    }

    // Update is called once per frame
    void Update()
    {
        if(itemsGotten == 3
            )
        {
            player.transform.position = resetPoint.position; 
        }
    }

    public void setItemsGotten()
    {
        itemsGotten++;
    }
}

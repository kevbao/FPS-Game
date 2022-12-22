using System.Collections;
using System.Collections.Generic;
using System.Security.Cryptography;
using UnityEngine;

public class EnemyHealth : MonoBehaviour
{
    public int currentHealth;

    //public GameObject DropFoodPrefab;
    public WeightedRandomList<GameObject> lootTable;
    //itemHolder is where the food item is spawned (should be in enemy)
    public Transform itemHolder;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (currentHealth <= 0)
        {
            GameObject item = lootTable.GetRandom();
            Instantiate(item, itemHolder.position, Quaternion.identity).transform.parent = null;
            itemHolder.gameObject.SetActive(true);
            //Instantiate(DropFoodPrefab, transform.position, Quaternion.identity);
            Destroy(this.gameObject);
        }
    }
}
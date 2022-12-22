using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class WinPoint : MonoBehaviour
{
    //Item item;
    private MeshCollider myCollider;
    private int currlevel;
    
    public GameManager gameManager;
    // Start is called before the first frame update
    void Start()
    {
        myCollider = GetComponent<MeshCollider>();
        myCollider.isTrigger = true;


    }

    // Update is called once per frame
    void Update()
    {
        
    }


    private void OnTriggerEnter(Collider other)
    {
        //var inventory = other.transform.GetComponent<Inventory>();
        //if (!inventory) return;
        if (other.CompareTag("Player"))
        {
            //InventorySystem.Instance.Add(item);
            Destroy(this.gameObject);
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
            //gameManager.CompleteLevel();
            //Application.LoadLevel(1);


        }


    }
}

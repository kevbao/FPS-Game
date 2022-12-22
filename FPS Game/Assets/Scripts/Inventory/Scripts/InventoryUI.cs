using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class InventoryUI : MonoBehaviour
{
    public GameObject inventoryUI;  // The entire UI
    public Transform  Content;   // The parent object of all the items

    InventorySystem inventory;	// Our current inventory

    // Start is called before the first frame update
    void Start()
    {

        inventory = InventorySystem.Instance;
        inventory.onItemChangedCallback += UpdateUI;
    }

    // Update is called once per frame
    void Update() // Check to see if we should open/close the inventory
    {

        //if (Input.GetButtonDown("Inventory"))
        //{
            //inventoryUI.SetActive(!inventoryUI.activeSelf);
            UpdateUI();
        //}
    }

    // Update the inventory UI by:
    //		- Adding items
    //		- Clearing empty slots
    // This is called using a delegate on the Inventory.
    public void UpdateUI()
    {
        Inventory[] slots = GetComponentsInChildren<Inventory>();

        for (int i = 0; i < slots.Length; i++)
        {
            if (i < inventory.itemList.Count)
            {
                slots[i].AddItem(inventory.itemList[i]);
            }
            else
            {
                slots[i].ClearSlot();
            }
        }
    }
}

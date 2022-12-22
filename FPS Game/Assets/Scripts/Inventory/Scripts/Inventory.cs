using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

// InventoryItemController
// Inventoryslot
public class Inventory : MonoBehaviour
{
    Item item;
    //private InventorySystem inventory;

    public Image icon;
    //public Text Name;
    public TextMeshProUGUI itemName;
    public TextMeshProUGUI count;
    public Button removeButton;


    //// Start is called before the first frame update
    //void Start()
    //{
    //    //inventory = new InventorySystem();
    //}

    //// Update is called once per frame
    //void Update()
    //{

    //}

    public void AddItem(Item newItem)
    {
        item = newItem;
        icon.sprite = item.icon;
        itemName.text = item.itemName;
        count.text = item.amount.ToString();
        icon.enabled = true;
        removeButton.interactable = true;
    }
    // Clear the slot
    public void ClearSlot()
    {
        item = null;

        icon.sprite = null;
        icon.enabled = false;
        removeButton.interactable = false;
    }
    // If the remove button is pressed, this function will be called.
    public void RemoveItem()
    {
        InventorySystem.Instance.Remove(item);
        Destroy(gameObject);
    }
    public void UseItem()
    {
        if (item != null)
        {
            item.Use();
        }
        //switch (item.itemType)
        //{
        //    //case Item.ItemType.Ammo:
        //    //    //Player.Instance.IncreaseHealth(item.value);

        //    //case Item.ItemType.Food:  
        //        //Player.Instance.IncreaseExp(item.value);
        //}
        RemoveItem();

    }
}

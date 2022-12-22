 using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InventorySystem : MonoBehaviour
{
    public static InventorySystem Instance;
    public List<Item> itemList = new List<Item>();

    public Transform ItemContent;
    public GameObject InventoryItem;

    public bool[] isFull;
    public static Inventory[] InventoryItems;


    public delegate void OnItemChanged();
    public OnItemChanged onItemChangedCallback;
    //public Toggle EnableRemove;

    // Start is called before the first frame update
    //public InventorySystem()
    //{
    //    itemList = new List<Item>();
    //    Debug.Log("Inventory");
    //    AddItem(new Item { itemType = Item.ItemType.food, amount = 1 });
    //    Debug.Log("Add Item" + itemList.Count);
    //}
    // Start is called before the first frame update
    private void Awake()
    {
        //inventory = new InventorySystem();
        Instance = this;
    }

    //// Update is called once per frame
    //void Update()
    //{

    //}
    public void Add(Item item)
    {
        itemList.Add(item);

        if (onItemChangedCallback != null)
            onItemChangedCallback.Invoke();
    }

    public void Remove(Item item)
    {
        itemList.Remove(item);
        if (onItemChangedCallback != null)
            onItemChangedCallback.Invoke();
    }

    public void ListItems()
    {
        //clean content before open
        //itemList.Remove(ItemContent);
        foreach(Transform item in ItemContent)
        {
            Destroy(item.gameObject);

        }
        foreach (var item in itemList)
        {
            //GameObject obj = Instantiate(InventoryItem, ItemContent);
            //var itemIcon = obj.transform.Find("ItemIcon").GetComponent<Image>();
            //var itemName = obj.transform.Find("ItemName").GetComponent<Text>();
            //var removeButton = obj.transform.Find("RemoveButton").GetComponent<Button>();

            //itemName.text = item.itemName;
            //itemIcon.sprite = item.icon;
            //if (EnableRemove.isOn)
            //    removeButton.gameObject.SetActive(true);

        }
        SetInventoryItems();
    }
    //public void EnableItemesRemove()
    //{
    //    if (EnableRemove.isOn)
    //    {
    //        foreach (Transform item in ItemContent)
    //        {
    //            item.Find("RemoveButton").gameObject.SetActive(true);
    //        }
    //    }
    //    else
    //    {
    //        foreach (Transform item in ItemContent)
    //        {
    //            item.Find("RemoveButton").gameObject.SetActive(false);
    //        }
    //    }

    //}
    public void SetInventoryItems()
    {
         
        for(int i = 0; i < itemList.Count; i++)
        {
            InventoryItems[i].AddItem(itemList[i]);
        }

    }

}


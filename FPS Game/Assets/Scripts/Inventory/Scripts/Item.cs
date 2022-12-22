using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "New Item", menuName = "Item/Create New Item")]

public class Item : ScriptableObject
{
    public enum ItemType
    {
        Food,
        Gun,
        //gun2,
        //gun3,
        Ammo,
        //freezeAmmo,

    }
    public int id;
    public string itemName;
    public int amount;
    public Sprite icon;
    public ItemType itemType;

    // Called when the item is pressed in the inventory
    public virtual void Use()
    {
        // Use the item
        // Something may happen
        //switch (item.itemType)
        //{
        //    //case Item.ItemType.Ammo:
        //    //    //Player.Instance.IncreaseHealth(item.value);

        //    //case Item.ItemType.Food:  
        //        //Player.Instance.IncreaseExp(item.value);
        //}
    }

}

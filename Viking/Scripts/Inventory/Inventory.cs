using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Inventory
{
    private List<Items> itemsList;

    public Inventory()
    {
        itemsList = new List<Items>();
        AddItem(new Items { itemType = Items.ItemType.Weapon, amount = 2 });
        AddItem(new Items { itemType = Items.ItemType.Medkit, amount = 1 });
        AddItem(new Items { itemType = Items.ItemType.Coin, amount = 1 });
        Debug.Log(itemsList.Count);
    }

    public void AddItem(Items Item)
    {
        itemsList.Add(Item);
    }

    public List<Items> GetItemsList()
    {
        return itemsList;
    }
}

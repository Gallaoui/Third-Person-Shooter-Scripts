using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class InventoryUI : MonoBehaviour
{
    private Inventory inventory;
    private GameObject IconSprite;
    private GameObject DropSprite;
    [SerializeField] private GameObject Slot1;
    [SerializeField] private GameObject Slot2;
    [SerializeField] private GameObject Slot3;
    [SerializeField] private GameObject Slot4;
    [SerializeField] private GameObject Slot5;
    [SerializeField] private GameObject Slot6;
    [SerializeField] private GameObject Slot7;
    [SerializeField] private GameObject Slot8;
    [SerializeField] private GameObject Slot9;

    public void SetInventory(Inventory inv)
    {
        this.inventory = inv;
        RefreshUI();
    }
    private void currentSlot(string name, Items item)
    {
        if (name == nameof(Slot1))
        {
           IconSprite = Slot1.transform.GetChild(0).gameObject.transform.GetChild(0).gameObject;
           DropSprite = Slot1.transform.GetChild(1).gameObject;
            DropSprite.GetComponent<Image>().enabled = true;
            IconSprite.GetComponent<Image>().enabled = true;
            IconSprite.GetComponent<Image>().sprite = item.GetSprite();
        }
        else if (name == nameof(Slot2))
        {
            IconSprite = Slot2.transform.GetChild(0).gameObject.transform.GetChild(0).gameObject;
            DropSprite = Slot2.transform.GetChild(1).gameObject;
            DropSprite.GetComponent<Image>().enabled = true;
            IconSprite.GetComponent<Image>().enabled = true;
            IconSprite.GetComponent<Image>().sprite = item.GetSprite();
        }
        else if (name == nameof(Slot3))
        {
            IconSprite = Slot3.transform.GetChild(0).gameObject.transform.GetChild(0).gameObject;
            DropSprite = Slot3.transform.GetChild(1).gameObject;
            DropSprite.GetComponent<Image>().enabled = true;
            IconSprite.GetComponent<Image>().enabled = true;
            IconSprite.GetComponent<Image>().sprite = item.GetSprite();
        }
        else if (name == nameof(Slot4))
        {
            IconSprite = Slot4.transform.GetChild(0).gameObject.transform.GetChild(0).gameObject;
            DropSprite = Slot4.transform.GetChild(1).gameObject;
            DropSprite.GetComponent<Image>().enabled = true;
            IconSprite.GetComponent<Image>().enabled = true;
            IconSprite.GetComponent<Image>().sprite = item.GetSprite();
        }
        else if (name == nameof(Slot5))
        {
            IconSprite = Slot5.transform.GetChild(0).gameObject.transform.GetChild(0).gameObject;
            DropSprite = Slot5.transform.GetChild(1).gameObject;
            DropSprite.GetComponent<Image>().enabled = true;
            IconSprite.GetComponent<Image>().enabled = true;
            IconSprite.GetComponent<Image>().sprite = item.GetSprite();
        }
        else if (name == nameof(Slot6))
        {
            IconSprite = Slot6.transform.GetChild(0).gameObject.transform.GetChild(0).gameObject;
            DropSprite = Slot6.transform.GetChild(1).gameObject;
            DropSprite.GetComponent<Image>().enabled = true;
            IconSprite.GetComponent<Image>().enabled = true;
            IconSprite.GetComponent<Image>().sprite = item.GetSprite();
        }
        else if (name == nameof(Slot7))
        {
            IconSprite = Slot7.transform.GetChild(0).gameObject.transform.GetChild(0).gameObject;
            DropSprite = Slot7.transform.GetChild(1).gameObject;
            DropSprite.GetComponent<Image>().enabled = true;
            IconSprite.GetComponent<Image>().enabled = true;
            IconSprite.GetComponent<Image>().sprite = item.GetSprite();
        }
        else if (name == nameof(Slot8))
        {
            IconSprite = Slot8.transform.GetChild(0).gameObject.transform.GetChild(0).gameObject;
            DropSprite = Slot8.transform.GetChild(1).gameObject;
            DropSprite.GetComponent<Image>().enabled = true;
            IconSprite.GetComponent<Image>().enabled = true;
            IconSprite.GetComponent<Image>().sprite = item.GetSprite();
        }
        else if (name == nameof(Slot9))
        {
            IconSprite = Slot9.transform.GetChild(0).gameObject.transform.GetChild(0).gameObject;
            DropSprite = Slot9.transform.GetChild(1).gameObject;
            DropSprite.GetComponent<Image>().enabled = true;
            IconSprite.GetComponent<Image>().enabled = true;
            IconSprite.GetComponent<Image>().sprite = item.GetSprite();
        }
    }
    private void RefreshUI()
    {
        int x = 1;
        foreach(Items item in inventory.GetItemsList())
        {
            currentSlot("Slot" + x, item);
            x++;
        }
    }

}

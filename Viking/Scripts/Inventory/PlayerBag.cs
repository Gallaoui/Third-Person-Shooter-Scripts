using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerBag : MonoBehaviour
{
    [SerializeField] private InventoryUI UIinventory;

    private Inventory inventory;
    public GameObject PlayerInventory;


    private PlayerControls pc;
    private bool tap;
    private void Awake()
    {
        pc = new PlayerControls(); 
        inventory = new Inventory();
        UIinventory.SetInventory(inventory);
    }

    private void OnEnable()
    {
        pc.Player.Inventory.performed += ctx =>
        {
            tap = !tap;
        };

        pc.Enable();
    }
    private void OnDisable()
    {
        pc.Disable();
    }

    private void Update()
    {
        if(tap)
        {
            PlayerInventory.SetActive(true);
            PlayerInventory.GetComponent<Animator>().Play("Open");
        }
        else
        {
            PlayerInventory.GetComponent<Animator>().Play("Close");
        }
    }
    
}

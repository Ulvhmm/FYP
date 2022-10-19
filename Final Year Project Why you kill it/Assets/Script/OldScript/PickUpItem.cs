using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PickUpItem : Interactable
{
    public Item item; 

    public override void Interact()
    {
        base.Interact();

        InventoryManager.instance.AddItem(item);

        Destroy(gameObject);

    }
}




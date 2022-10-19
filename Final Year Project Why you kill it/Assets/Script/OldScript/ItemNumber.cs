using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ItemNumber : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        //InventoryManager.instance.UpdateInventory += UpdateItemNumber;
        GetComponent<Text>().text = "Survival Items: 0/" + InventoryManager.instance.space;
    }

    public void UpdateItemNumber()
    {
        GetComponent<Text>().text = "Survival Items: " + InventoryManager.instance.items.Count + "/" + InventoryManager.instance.space;
    }
}

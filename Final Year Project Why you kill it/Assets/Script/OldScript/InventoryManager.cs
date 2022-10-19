using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class InventoryManager : MonoBehaviour
{
    #region Singleton
    public static InventoryManager instance;

    // first function called in script 
    void Awake()
    {
        instance = this;
    }
    #endregion

    public List<Item> items = new List<Item>();
    public int space = 3;
    public int storedItem = 0;
    public GameObject InteractableCar;

    public bool AddItem(Item item)
    {
        items.Add(item);
        storedItem++;
        FindObjectOfType<ItemNumber>().UpdateItemNumber();
        return true;
    }

        // Start is called before the first frame update
        void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (storedItem == 3)
        {
            InteractableCar.SetActive(true);
        }
    }
}

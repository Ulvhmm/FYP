using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OpenTradeSystem : Interactable
{
    public GameObject TradePanel;

    public override void Interact()
    {
        TradePanel.SetActive(!TradePanel.activeSelf);

        if (TradePanel.activeSelf)
        {
            Cursor.lockState = CursorLockMode.None;
            Cursor.visible = true;
            Time.timeScale = 0;
        }

        else
        {
            Cursor.lockState = CursorLockMode.Locked;
            Cursor.visible = false;
            Time.timeScale = 1;
        }
    }
    
    public void Update()
    {
        if (Input.GetKeyDown(KeyCode.V))
        {
            TradePanel.SetActive(true);
            Cursor.lockState = CursorLockMode.None;
            Cursor.visible = true;
            Time.timeScale = 0;
        }
    }
}

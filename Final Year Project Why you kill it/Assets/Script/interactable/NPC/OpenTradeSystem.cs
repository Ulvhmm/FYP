using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OpenTradeSystem : Interactable
{
    public GameObject TradePanel;

    public override void Interact()
    {
        TradePanel.SetActive(!TradePanel.activeSelf);
        Cursor.lockState = CursorLockMode.None;
        Cursor.visible = true;
    }
}

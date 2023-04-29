using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OpenTradeKeyEnter : MonoBehaviour
{
    public GameObject TradePanel;

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

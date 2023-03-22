using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cipher : Interactable
{
    public GameObject CipherPanel;

    public override void Interact()
    {
        CipherPanel.SetActive(!CipherPanel.activeSelf);

        if (CipherPanel.activeSelf)
        {
            Player.instance.GetComponent<PlayerMovement>().canMove = false;
            Cursor.lockState = CursorLockMode.None;
            Cursor.visible = true;
        }
        
        else
        {
            Player.instance.GetComponent<PlayerMovement>().canMove = true;
            Cursor.lockState = CursorLockMode.Locked;
            Cursor.visible = false;
        }

    }
}

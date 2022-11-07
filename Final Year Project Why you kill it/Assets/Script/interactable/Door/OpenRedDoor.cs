using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OpenRedDoor : Interactable
{
    public Animator animator;

    public override void Interact()
    {
        if (Player.instance.GetComponent<PlayerKeys>().Red_Key >= 1)
        {
            base.Interact();
            animator.SetBool("isOpen", true);
            //Deduct key
            Player.instance.GetComponent<PlayerKeys>().Red_Key -= 1;
        }

        else return;
    }
}

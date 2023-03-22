using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OpenRedDoor : OnceInteract
{
    public Animator animator;

    public override void Interact()
    {
        if (Player.instance.GetComponent<PlayerKeys>().Red_Key >= 1)
        {
            base.Interact();
            animator.SetBool("isOpen", true);
            StartCoroutine(DestroyRedDoor());
            //Deduct key
            Player.instance.GetComponent<PlayerKeys>().Red_Key -= 1;
        }

        else return;
    }

    IEnumerator DestroyRedDoor()
    {
        yield return new WaitForSeconds(2f);
        Destroy(gameObject);
    }
}

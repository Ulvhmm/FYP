using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OpenBlueDoor : OnceInteract
{
    public Animator animator;

    public override void Interact()
    {
        if (Player.instance.GetComponent<PlayerKeys>().Blue_Key >= 1)
        {
            base.Interact();
            animator.SetBool("isOpen", true);
            StartCoroutine(DestroyBlueDoor());
            //Deduct key
            Player.instance.GetComponent<PlayerKeys>().Blue_Key -= 1;
        }

        else return;
    }

    IEnumerator DestroyBlueDoor()
    {
        yield return new WaitForSeconds(2f);
        Destroy(gameObject);
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OpenYellowDoor : OnceInteract
{
    public Animator animator;

    public override void Interact()
    {
        if (Player.instance.GetComponent<PlayerKeys>().Yellow_Key >= 1)
        {
            base.Interact();
            animator.SetBool("isOpen", true);
            StartCoroutine(DestroyYellowDoor());
            //Deduct key
            Player.instance.GetComponent<PlayerKeys>().Yellow_Key -= 1;
        }

        else return;
    }

    IEnumerator DestroyYellowDoor()
    {
        yield return new WaitForSeconds(2f);
        Destroy(gameObject);
    }

}

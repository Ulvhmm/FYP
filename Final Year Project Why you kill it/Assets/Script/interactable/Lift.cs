using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Lift : Interactable
{
    public Animator animator;
    public bool isAvailable = true;

    public override void Interact()
    {
        base.Interact();
        if (isAvailable)
        {
            StartCoroutine(StartLift());
            isAvailable = false;
        }
    }

    IEnumerator StartLift()
    {
        animator.SetBool("isOn", true);
        yield return new WaitForSeconds(15f);
        animator.SetBool("isOn", false);
        yield return new WaitForSeconds(5f);
        isAvailable = true;
    }
}

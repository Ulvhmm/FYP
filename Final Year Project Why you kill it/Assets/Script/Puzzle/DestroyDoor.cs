using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyDoor : Interactable
{
    public GameObject Door;
    public Animator animator;

    //public AudioSource audioSource;

    public override void Interact()
    {
        //audioSource.Play();
        StartCoroutine(DoorDestory());
        animator.SetBool("isRotate", true);
    }

    IEnumerator DoorDestory()
    {
        yield return new WaitForSeconds(7f);
        Destroy(Door);
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnObject : Interactable
{
    public GameObject ObjectToSpawn;
    public Animator animator;

    //public AudioSource audioSource;

    public override void Interact()
    {
        //audioSource.Play();
        StartCoroutine(SpawningObject());
        animator.SetBool("isRotate", true);
    }

    IEnumerator SpawningObject()
    {
        yield return new WaitForSeconds(7f);
        ObjectToSpawn.SetActive(true);
    }
}

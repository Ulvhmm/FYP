using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotateStatus : Interactable
{
    public GameObject Statue;
    public Animator animator;

    public int CurrentStatus = 4;
    public int FinishStatus = 1;

    public bool isCorrect;

    //public AudioSource audioSource;

    public override void Interact()
    {
        CurrentStatus += 1;
        if (CurrentStatus > 4)
        {
            CurrentStatus = 1;
        }

        if(CurrentStatus == FinishStatus)
        {
            isCorrect = true;
        }
        else
        {
            isCorrect = false;
        }

        if (isCorrect)
        {
            Puzzle2Manager.instance.CompletedStatue += 3;
        }

        else
        {
            Puzzle2Manager.instance.CompletedStatue -= 1;
        }

        switch (CurrentStatus) 
        {
            case 1:
                StartCoroutine(Rotate90());
                break;
            case 2:
                StartCoroutine(Rotate180());
                break;
            case 3:
                StartCoroutine(Rotate270());
                break;

            case 4:
                StartCoroutine(Rotate360());
                break;
        }

        //audioSource.Play();
    }

    IEnumerator Rotate90()
    {
        interactableRadius = 0;
        animator.SetBool("isRotate1", true);
        animator.SetBool("isRotate4", false);
        yield return new WaitForSeconds(2f);
        interactableRadius = 6;
        if (Puzzle2Manager.instance.CompletedStatue == 12)
        {
            interactableRadius = 0;
        }
    }

    IEnumerator Rotate180()
    {
        interactableRadius = 0;
        animator.SetBool("isRotate2", true);
        animator.SetBool("isRotate1", false);
        yield return new WaitForSeconds(2f);
        interactableRadius = 6;
        if (Puzzle2Manager.instance.CompletedStatue == 12)
        {
            interactableRadius = 0;
        }
    }

    IEnumerator Rotate270()
    {
        interactableRadius = 0;
        animator.SetBool("isRotate3", true);
        animator.SetBool("isRotate2", false);
        yield return new WaitForSeconds(2f);
        interactableRadius = 6;
        if (Puzzle2Manager.instance.CompletedStatue == 12)
        {
            interactableRadius = 0;
        }
    }

    IEnumerator Rotate360()
    {
        interactableRadius = 0;
        animator.SetBool("isRotate4", true);
        animator.SetBool("isRotate3", false);
        yield return new WaitForSeconds(2f);
        interactableRadius = 6;
        if (Puzzle2Manager.instance.CompletedStatue == 12)
        {
            interactableRadius = 0;
        }
    }
}

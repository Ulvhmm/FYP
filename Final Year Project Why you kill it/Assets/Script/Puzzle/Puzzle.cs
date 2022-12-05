using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Puzzle : Interactable
{
    public GameObject SelfAlter;
    public GameObject SideAlter1;
    public GameObject SideAlter2;

    public AudioSource audioSource;

    public override void Interact()
    {
        SelfAlter.SetActive(!SelfAlter.activeSelf);
        audioSource.Play();
        if (SelfAlter.activeSelf)
        {
            PuzzleManager.instance.LightedCrystal += 1;
        }
        else
        {
            PuzzleManager.instance.LightedCrystal -= 1;
        }

        SideAlter1.SetActive(!SideAlter1.activeSelf);
        if (SideAlter1.activeSelf)
        {
            PuzzleManager.instance.LightedCrystal += 1;
        }
        else
        {
            PuzzleManager.instance.LightedCrystal -= 1;
        }

        SideAlter2.SetActive(!SideAlter2.activeSelf);
        if (SideAlter2.activeSelf)
        {
            PuzzleManager.instance.LightedCrystal += 1;
        }
        else
        {
            PuzzleManager.instance.LightedCrystal -= 1;
        }
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Puzzle : MonoBehaviour
{
    public GameObject LeftAlter;
    public GameObject SelfAlter;
    public GameObject RightAlter;

    // Start is called before the first frame update
    void Start()
    {
        if (SelfAlter.activeSelf)
        {
            PuzzleManager.instance.LightedCrystal += 1;
        }
    }

    // Update is called once per frame
    void Update()
    {

    }

    public void ChangeAlterStatus()
    {
        LeftAlter.SetActive(!LeftAlter.activeSelf);
        SelfAlter.SetActive(!SelfAlter.activeSelf);
        RightAlter.SetActive(!RightAlter.activeSelf);

        if (SelfAlter.activeSelf)
        {
            PuzzleManager.instance.LightedCrystal += 1;
        }
        else
        {
            PuzzleManager.instance.LightedCrystal -= 1;
        }

        if (LeftAlter.activeSelf)
        {
            PuzzleManager.instance.LightedCrystal += 1;
        }
        else
        {
            PuzzleManager.instance.LightedCrystal -= 1;
        }

        if (RightAlter.activeSelf)
        {
            PuzzleManager.instance.LightedCrystal += 1;
        }
        else
        {
            PuzzleManager.instance.LightedCrystal -= 1;
        }
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PuzzleManager : MonoBehaviour
{
    #region Singleton
    public static PuzzleManager instance;

    // first function called in script 
    void Awake()
    {
        instance = this;
    }
    #endregion

    public int LightedCrystal = 0;

    // Update is called once per frame
    void Update()
    {
        if (LightedCrystal == 5)
        {
            //PlayCutScene
        }

        Debug.Log(LightedCrystal);
    }
}
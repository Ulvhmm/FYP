using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerAttributes : MonoBehaviour
{
    #region Singleton
    public static PlayerAttributes instance;

    // first function called in script 
    void Awake()
    {
        instance = this;
    }

    #endregion

    public int Attack = 1;
    public int Defence = 1;
}

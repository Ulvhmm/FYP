using UnityEngine;

public class Player : MonoBehaviour
{
    #region Singleton
    public static Player instance;

    // first function called in script 
    void Awake()
    {
        instance = this;
    }

    #endregion
}

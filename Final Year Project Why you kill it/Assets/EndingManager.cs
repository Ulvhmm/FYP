using UnityEngine;
using UnityEngine.SceneManagement;

public class EndingManager : MonoBehaviour
{
    #region Singleton
    public static EndingManager instance;

    public GameObject FadePanel;

    // first function called in script 
    void Awake()
    {
        instance = this;
    }
    #endregion

    public bool GoodEnding = false;

    public void JumpToEnding()
    {
        if (GoodEnding)
        {

        }

        else
        {

        }
    }
}

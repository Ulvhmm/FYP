using System.Collections;
using System.Collections.Generic;
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

    public bool isGoodEnding = false;

    public void JumpToEnding()
    {
        if (isGoodEnding)
        {
            StartCoroutine(GoodEnding());
        }

        else
        {
            StartCoroutine(BadEnding());
        }
    }

    IEnumerator GoodEnding()
    {
        yield return new WaitForSeconds(2f);
        FadePanel.SetActive(true);
        yield return new WaitForSeconds(3f);
        SceneManager.LoadScene("GoodEnding");
    }

    IEnumerator BadEnding()
    {
        yield return new WaitForSeconds(2f);
        FadePanel.SetActive(true);
        yield return new WaitForSeconds(3f);
        SceneManager.LoadScene("BadEnding");
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Puzzle2Manager : MonoBehaviour
{
    #region Singleton
    public static Puzzle2Manager instance;

    // first function called in script 
    void Awake()
    {
        instance = this;
    }
    #endregion

    public int CompletedStatue = 0;

    public GameObject Barrier;

    public GameObject OriginPuzzle;
    public GameObject CompletePuzzle;

    // Update is called once per frame
    void Update()
    {
        if (CompletedStatue == 12)
        {
           StartCoroutine(DestroyBarrier());
        }
    }

    IEnumerator DestroyBarrier()
    {
        yield return new WaitForSeconds(2f);
        Destroy(Barrier);
        OriginPuzzle.SetActive(false);
        CompletePuzzle.SetActive(true);
    }
}

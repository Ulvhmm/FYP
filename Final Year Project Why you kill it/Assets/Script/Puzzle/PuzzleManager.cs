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
    public GameObject OriginalAlter;
    public GameObject SolvedAlter;

    public GameObject LASR1;
    public GameObject LASR2;
    public GameObject LASR3;
    public GameObject LASR4;
    public GameObject LASR5;
    public GameObject LASR6;
    public GameObject LASR7;
    public GameObject LASR8;
    public GameObject LASR9;
    public GameObject LASR10;
    public GameObject LASR11;
    public GameObject LASR12;
    public GameObject LASR13;
    public GameObject LASR14;
    public GameObject LASR15;
    public GameObject LASR16;

    public GameObject BigCrystalBall;

    public AudioSource Music1;
    public Animator animator;

    void Start()
    {
        Music1 = GameObject.Find("AlterMusic").GetComponent<AudioSource>();
        animator = GameObject.Find("NPC 1").GetComponent<Animator>();

        LASR1.SetActive(false);
        LASR2.SetActive(false);
        LASR3.SetActive(false);
        LASR4.SetActive(false);
        LASR5.SetActive(false);
        LASR6.SetActive(false);
        LASR7.SetActive(false);
        LASR8.SetActive(false);
        LASR9.SetActive(false);
        LASR10.SetActive(false);
        LASR11.SetActive(false);
        LASR12.SetActive(false);
        LASR13.SetActive(false);
        LASR14.SetActive(false);
        LASR15.SetActive(false);
        LASR16.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        if (LightedCrystal == 16)
        {
            //PlayCutScene
            StartCoroutine(PlayCutScene());
            LightedCrystal = 0;
        }
    }

    IEnumerator PlayCutScene()
    {
        yield return new WaitForSeconds(1f);
        OriginalAlter.SetActive(false);
        SolvedAlter.SetActive(true);
        Music1.enabled = true;
        LASR1.SetActive(true);

        yield return new WaitForSeconds(1f);
        LASR2.SetActive(true);

        yield return new WaitForSeconds(1f);
        LASR3.SetActive(true);

        yield return new WaitForSeconds(1f);
        LASR4.SetActive(true);

        yield return new WaitForSeconds(1f);
        LASR5.SetActive(true);

        yield return new WaitForSeconds(1f);
        LASR6.SetActive(true);

        yield return new WaitForSeconds(1f);
        LASR7.SetActive(true);

        yield return new WaitForSeconds(1f);
        LASR8.SetActive(true);

        yield return new WaitForSeconds(1f);
        LASR9.SetActive(true);

        yield return new WaitForSeconds(1f);
        LASR10.SetActive(true);

        yield return new WaitForSeconds(1f);
        LASR11.SetActive(true);

        yield return new WaitForSeconds(1f);
        LASR12.SetActive(true);

        yield return new WaitForSeconds(1f);
        LASR13.SetActive(true);

        yield return new WaitForSeconds(1f);
        LASR14.SetActive(true);

        yield return new WaitForSeconds(1f);
        LASR15.SetActive(true);

        yield return new WaitForSeconds(1f);
        LASR16.SetActive(true);

        yield return new WaitForSeconds(1f);
        LASR1.SetActive(false);
        LASR2.SetActive(false);
        LASR3.SetActive(false);
        LASR4.SetActive(false);
        LASR5.SetActive(false);
        LASR6.SetActive(false);
        LASR7.SetActive(false);
        LASR8.SetActive(false);
        LASR9.SetActive(false);
        LASR10.SetActive(false);
        LASR11.SetActive(false);
        LASR12.SetActive(false);
        LASR13.SetActive(false);
        LASR14.SetActive(false);
        LASR15.SetActive(false);
        LASR16.SetActive(false);

        BigCrystalBall.SetActive(false);
        animator.enabled = true;

        Music1.enabled = false;
    }
}
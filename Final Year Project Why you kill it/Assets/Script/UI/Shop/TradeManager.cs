using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TradeManager : MonoBehaviour
{
    #region Singleton
    public static TradeManager instance;

    // first function called in script 
    void Awake()
    {
        instance = this;
    }
    #endregion

    public int CurrentMoneyTotal = 10;
    public int HealthValue = 100;

    public GameObject NoMoneyDisplay;
    public GameObject PurchaseDisplay;

    public GameObject TradePanel;

    public AudioClip Clip1;
    public AudioClip Clip2;
    public AudioClip Clip3;

    public AudioSource Source;

    public void Update()
    {
        HealthValue = 100 + Player.instance.GetComponent<PlayerAttributes>().Buytime * 10;

        if(Input.GetKeyDown(KeyCode.V))
        {
            TradePanel.SetActive(!TradePanel.activeSelf);
            Cursor.lockState = CursorLockMode.None;
            Cursor.visible = true;
        }
    }

    public void IncreaseHealth()
    {
        if (Player.instance.GetComponent<PlayerAttributes>().Currency >= CurrentMoneyTotal)
        {
            Player.instance.GetComponent<health>().Health += HealthValue;
            Player.instance.GetComponent<PlayerAttributes>().Currency -= CurrentMoneyTotal;
            CurrentMoneyTotal += 1;
            Player.instance.GetComponent<PlayerAttributes>().Buytime += 1;
            StopAllCoroutines();
            StartCoroutine(PurchaseSuccess());

            Source.PlayOneShot(Clip1, 1.2f);
        }

        else
        {
            StopAllCoroutines();
            StartCoroutine(NoMoney());
            PurchaseDisplay.SetActive(false);
            Source.PlayOneShot(Clip2, 1.2f);
        }
    }

    public void IncreaseAttack()
    {
        if (Player.instance.GetComponent<PlayerAttributes>().Currency >= CurrentMoneyTotal)
        {
            Player.instance.GetComponent<PlayerAttributes>().Attack += 2;
            Player.instance.GetComponent<PlayerAttributes>().Currency -= CurrentMoneyTotal;
            CurrentMoneyTotal += 1;
            Player.instance.GetComponent<PlayerAttributes>().Buytime += 1;
            StopAllCoroutines();
            StartCoroutine(PurchaseSuccess());

            Source.PlayOneShot(Clip1, 1.2f);
        }

        else
        {
            StopAllCoroutines();
            StartCoroutine(NoMoney());
            PurchaseDisplay.SetActive(false);
            Source.PlayOneShot(Clip2, 1.2f);
        }
    }

    public void IncreaseDefence()
    {
        if (Player.instance.GetComponent<PlayerAttributes>().Currency >= CurrentMoneyTotal)
        {
            Player.instance.GetComponent<PlayerAttributes>().Defence += 2;
            Player.instance.GetComponent<PlayerAttributes>().Currency -= CurrentMoneyTotal;
            CurrentMoneyTotal += 1;
            Player.instance.GetComponent<PlayerAttributes>().Buytime += 1;
            StopAllCoroutines();
            StartCoroutine(PurchaseSuccess());

            Source.PlayOneShot(Clip1, 1.2f);
        }

        else
        {
            StopAllCoroutines();
            StartCoroutine(NoMoney());
            PurchaseDisplay.SetActive(false);
            Source.PlayOneShot(Clip2, 1.2f);
        }
    }

    public void CloseTradeMenu()
    {
        Source.PlayOneShot(Clip3, 2f);
        TradePanel.SetActive(false);
        Cursor.lockState = CursorLockMode.Locked;
        Cursor.visible = false;
    }



    IEnumerator NoMoney()
    {
        NoMoneyDisplay.SetActive(true);
        yield return new WaitForSeconds(2f);
        NoMoneyDisplay.SetActive(false);
    }

    IEnumerator PurchaseSuccess()
    {
        PurchaseDisplay.SetActive(true);
        yield return new WaitForSeconds(2f);
        PurchaseDisplay.SetActive(false);
    }

}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Puzzle3Manager : MonoBehaviour
{
    #region Singleton
    public static Puzzle3Manager instance;

    // first function called in script 
    void Awake()
    {
        instance = this;
    }
    #endregion

    public int Number1 = 0;
    public int Number2 = 0;
    public int Number3 = 0;
    public int Number4 = 0;

    public int Cipher1 = 6;
    public int Cipher2 = 7;
    public int Cipher3 = 3;
    public int Cipher4 = 8;

    public GameObject CipherPanel;
    public GameObject Cipher;
    public GameObject Barrier;

    public GameObject ErrorHint;

    public AudioClip ArrowClip;
    public AudioClip WrongClip;
    public AudioClip CorrectClip;

    public AudioSource Source;

    public void IncreaseNumber1()
    {
        Number1 += 1;
        Source.PlayOneShot(ArrowClip);
        if (Number1 > 9)
        {
            Number1 = 0;
        }
    }

    public void IncreaseNumber2()
    {
        Number2 += 1;
        Source.PlayOneShot(ArrowClip);
        if (Number2 > 9)
        {
            Number2 = 0;
        }
    }

    public void IncreaseNumber3()
    {
        Number3 += 1;
        Source.PlayOneShot(ArrowClip);
        if (Number3 > 9)
        {
            Number3 = 0;
        }
    }

    public void IncreaseNumber4()
    {
        Number4 += 1;
        Source.PlayOneShot(ArrowClip);
        if (Number4 > 9)
        {
            Number4 = 0;
        }
    }

    public void DecreaseNumber1()
    {
        Number1 -= 1;
        Source.PlayOneShot(ArrowClip);
        if (Number1 < 0)
        {
            Number1 = 9;
        }
    }

    public void DecreaseNumber2()
    {           
        Number2 -= 1;
        Source.PlayOneShot(ArrowClip);
        if (Number2 < 0)
        {
            Number2 = 9;
        }    
    }           
                
    public void DecreaseNumber3()
    {           
        Number3 -= 1;
        Source.PlayOneShot(ArrowClip);
        if (Number3 < 0)
        {
            Number3 = 9;
        }         
    }           
                
    public void DecreaseNumber4()
    {
        Number4 -= 1;
        Source.PlayOneShot(ArrowClip);
        if (Number4 < 0)
        {
            Number4 = 9;
        } 
    }

    public void CheckPassword()
    {
        if (Number1 == Cipher1 && Number2 == Cipher2 && Number3 == Cipher3 && Number4 == Cipher4)
        {
            Cipher.SetActive(false);
            Barrier.SetActive(false);
            CipherPanel.SetActive(false);
            Source.PlayOneShot(CorrectClip);
            Player.instance.GetComponent<PlayerMovement>().canMove = true;
            Cursor.lockState = CursorLockMode.Locked;
            Cursor.visible = false;
        }

        else
        {
            StartCoroutine(DisplayCodeError());
        }
    }

    public void CloseInterface()
    {
         CipherPanel.SetActive(false);
         Player.instance.GetComponent<PlayerMovement>().canMove = true;
            Cursor.lockState = CursorLockMode.Locked;
            Cursor.visible = false;
    }

    IEnumerator DisplayCodeError()
    {
        ErrorHint.SetActive(true);
        Source.PlayOneShot(WrongClip);
        yield return new WaitForSeconds(2f);
        ErrorHint.SetActive(false);
    }
}

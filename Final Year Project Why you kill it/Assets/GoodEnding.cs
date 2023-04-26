using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;

public class GoodEnding : MonoBehaviour
{
    public float textSpeed;
    [SerializeField] TextMeshProUGUI dialogBox;
    public string[] lines;

    private int index;

    public GameObject DialogPanel;

    //pages
    public GameObject Page1;
    public GameObject Page2;
    public GameObject Page3;
    public GameObject Page4;
    public GameObject Page5;
    public GameObject Page6;
    public GameObject Page7;
    public GameObject Page8;
    public GameObject Page9;
    public GameObject Page10;

    public GameObject ContinueHint;
    public GameObject BackButton;

    public GameObject DialogSprite;
    public int keypressed = 0;

    public bool DialogFinished = false;
    public bool isActive = true;

    public Animator BlackPanel;
    public GameObject blackPanel;

    // Start is called before the first frame update
    void Start()
    {
        Invoke("CoolDown", 2f);
        dialogBox.text = string.Empty;
        ShowDialog();
    }

    void Update() {
        if(DialogFinished && Input.anyKey){

            DialogFinished = false;
            keypressed += 1;
            isActive = true;

            Invoke("CoolDown", 3f);

            if (dialogBox.text == lines[index]){
                if (keypressed == 3 || keypressed == 5 || keypressed == 7 || keypressed == 9 || keypressed == 10 || keypressed == 12 || keypressed == 13 || keypressed == 14 || keypressed == 15 || keypressed == 16 || keypressed == 17 || keypressed == 18 || keypressed == 19 || keypressed == 20 || keypressed == 21 || keypressed == 22 || keypressed == 23 || keypressed == 24 || keypressed == 27 || keypressed == 29 || keypressed == 30)
                {
                    NextLine();
                }
                else
                {
                    Invoke("NextLine", 1.2f);
                }
            }
            else{

                StopAllCoroutines();
                dialogBox.text = lines[index];
            }
        }

        switch (keypressed)
        {
            case 1:
                if (isActive)
                {
                    StartCoroutine(SwtichPage2());
                }
                break;
            case 2:
                if (isActive)
                {
                    StartCoroutine(SwtichPage3());
                }
                break;
            case 3:
                break;
            case 4:
                if (isActive)
                {
                    StartCoroutine(SwtichPage4());
                }
                break;
            case 5:
                break;
            case 6:
                if (isActive)
                {
                    StartCoroutine(SwtichPage5());
                }
                break;
            case 7:
                break;
            case 8:
                if (isActive)
                {
                    StartCoroutine(SwtichPage6());
                }
                break;
            case 9:
                break;
            case 10:
                break;
            case 11:
                break;
            case 12:
                break;
            case 13:
                break;
            case 14:
                break;
            case 15:
                break;
            case 16:
                break;
            case 17:
                break;
            case 18:
                break;
            case 19:
                break;
            case 20:
                break;
            case 21:
                break;
            case 22:
                break;
            case 23:
                break;
            case 24:
                break;
            case 25:
                if (isActive)
                {
                    StartCoroutine(SwtichPage7());
                }
                break;
            case 26:
                if (isActive)
                {
                    StartCoroutine(SwtichPage8());
                }
                break;
            case 27:
                break;
            case 28:
                if (isActive)
                {
                    StartCoroutine(SwtichPage9());
                }
                break;
            case 29:
                break;
            case 30:
                break;
            case 31:
                if (isActive)
                {
                    DialogPanel.SetActive(false);
                    StartCoroutine(SwtichPage10());
                }
                break;
        }

        if (DialogFinished)
        {
            ContinueHint.SetActive(true);
        }
        
        else
        {
            ContinueHint.SetActive(false);
        }

    }

    //dialog related functions

    void ShowDialog(){
        index = 0;
        StartCoroutine(Dialog());
    }

    void CoolDown(){
        DialogFinished = true;
    }

    IEnumerator Dialog(){
        dialogBox.text = "";

        foreach (char c in lines[index].ToCharArray())
        {
            dialogBox.text += c;
            yield return new WaitForSeconds(textSpeed);
        }
    }

    void NextLine(){
        if(index < lines.Length - 1){
            index++;
            dialogBox.text = string.Empty;
            StartCoroutine(Dialog());
        }else
        {
            dialogBox.enabled = false;
            DialogSprite.SetActive(false);
        }
    }

    IEnumerator SwtichPage2()
    {
        isActive = false;
        BlackPanel.SetBool("isFade", true);
        yield return new WaitForSeconds (1f);
        Page1.SetActive(false);
        Page2.SetActive(true);
        yield return new WaitForSeconds (0.2f);
        BlackPanel.SetBool("isFade", false);
    }

    IEnumerator SwtichPage3()
    {
        isActive = false;
        BlackPanel.SetBool("isFade", true);
        yield return new WaitForSeconds (1f);
        Page2.SetActive(false);
        Page3.SetActive(true);
        yield return new WaitForSeconds (0.2f);
        BlackPanel.SetBool("isFade", false);
    }

    IEnumerator SwtichPage4()
    {
        isActive = false;
        BlackPanel.SetBool("isFade", true);
        yield return new WaitForSeconds (1f);
        Page3.SetActive(false);
        Page4.SetActive(true);
        yield return new WaitForSeconds (0.2f);
        BlackPanel.SetBool("isFade", false);
    }

    IEnumerator SwtichPage5()
    {
        isActive = false;
        BlackPanel.SetBool("isFade", true);
        yield return new WaitForSeconds (1f);
        Page4.SetActive(false);
        Page5.SetActive(true);
        yield return new WaitForSeconds (0.2f);
        BlackPanel.SetBool("isFade", false);
    }

    IEnumerator SwtichPage6()
    {
        isActive = false;
        BlackPanel.SetBool("isFade", true);
        yield return new WaitForSeconds (1f);
        Page5.SetActive(false);
        Page6.SetActive(true);
        yield return new WaitForSeconds (0.2f);
        BlackPanel.SetBool("isFade", false);
    }

    IEnumerator SwtichPage7()
    {
        isActive = false;
        BlackPanel.SetBool("isFade", true);
        yield return new WaitForSeconds (1f);
        Page6.SetActive(false);
        Page7.SetActive(true);
        yield return new WaitForSeconds (0.2f);
        BlackPanel.SetBool("isFade", false);
    }

    IEnumerator SwtichPage8()
    {
        isActive = false;
        BlackPanel.SetBool("isFade", true);
        yield return new WaitForSeconds (1f);
        Page7.SetActive(false);
        Page8.SetActive(true);
        yield return new WaitForSeconds (0.2f);
        BlackPanel.SetBool("isFade", false);
    }

    IEnumerator SwtichPage9()
    {
        isActive = false;
        BlackPanel.SetBool("isFade", true);
        yield return new WaitForSeconds (1f);
        Page8.SetActive(false);
        Page9.SetActive(true);
        yield return new WaitForSeconds (0.2f);
        BlackPanel.SetBool("isFade", false);
    }

    IEnumerator SwtichPage10()
    {
        isActive = false;
        BlackPanel.SetBool("isFade", true);
        yield return new WaitForSeconds (1f);
        Page9.SetActive(false);
        Page10.SetActive(true);
        yield return new WaitForSeconds (0.2f);
        BlackPanel.SetBool("isFade", false);
        yield return new WaitForSeconds (2f);
        blackPanel.SetActive(false);
        BackButton.SetActive(true);
    }

}

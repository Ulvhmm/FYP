using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;

public class ComicManager : MonoBehaviour
{
    public float textSpeed;
    [SerializeField] TextMeshProUGUI dialogBox;
    public string[] lines;

    private int index;

    //pages
    public GameObject Page1;
    public GameObject Page2;
    public GameObject Page3;
    public GameObject Page4;
    public GameObject Page5;
    public GameObject Page6;
    public GameObject Page7;
    public GameObject Page8;

    public GameObject ContinueHint;

    public GameObject DialogSprite;
    public int keypressed = 0;

    public bool DialogFinished = false;
    public bool isActive = true;

    public Animator BlackPanel;

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
                if (keypressed == 4 || keypressed == 5 || keypressed == 6 || keypressed == 8 || keypressed == 12 || keypressed == 13)
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
                if (isActive)
                {
                    StartCoroutine(SwtichPage4());
                }
                break;
            case 4:
                break;
            case 5:
                break;
            case 6:
                break;
            case 7:
                if (isActive)
                {
                    StartCoroutine(SwtichPage5());
                }
                break;
            case 8:
                break;
            case 9:
                if (isActive)
                {
                    StartCoroutine(SwtichPage6());
                }
                break;
            case 10:
                if (isActive)
                {
                    StartCoroutine(SwtichPage7());
                }
                break;
            case 11:
                if (isActive)
                {
                    StartCoroutine(SwtichPage8());
                }
                break;
            case 12:
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
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
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

}

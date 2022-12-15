using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

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


    public GameObject DialogSprite;
    public int keypressed = 0;

   

    // Start is called before the first frame update
    void Start()
    {
        dialogBox.text = string.Empty;
        ShowDialog();
    }

    void Update() {
        if(Input.GetKeyDown(KeyCode.E)){

            keypressed += 1;

            if(dialogBox.text == lines[index]){
                NextLine();
            }else{
                StopAllCoroutines();
                dialogBox.text = lines[index];
            }
        }

        switch (keypressed)
        {
            case 1:
                Page1.SetActive(false);
                Page2.SetActive(true);
                break;
            case 2:
                Page2.SetActive(false);
                Page3.SetActive(true);
                break;
            case 3:
                break;
            case 4:
                Page3.SetActive(false);
                Page4.SetActive(true);
                break;
            case 5:
                Page4.SetActive(false);
                Page5.SetActive(true);
                break;
            case 6:
                Page5.SetActive(false);
                Page6.SetActive(true);
                break;
        }
        

    }

    //dialog related functions

    void ShowDialog(){
        index = 0;
        StartCoroutine(Dialog());
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

    
}

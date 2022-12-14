using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class ComicManager : MonoBehaviour
{
    [SerializeField] int letter;
    [SerializeField] TextMeshProUGUI dialogBox;

    public GameObject Page1;
    public GameObject Page2;
    public int keypressed = 0;

    public void ChangePage1(){
        Page1.SetActive(false);
        Page2.SetActive(true);
    }

    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(Dialog("Dylen is missing."));
    }

    void Update() {
        if(Input.GetKeyDown(KeyCode.E)){
            keypressed += 1;
        }

        if(keypressed == 0){
            ChangePage1();
        }

    }

    public IEnumerator Dialog(string dialog){
        dialogBox.text = "";

        foreach (var text in dialog)
        {
            dialogBox.text += text;
            yield return new WaitForSeconds(1f / letter);
        }
    }
}

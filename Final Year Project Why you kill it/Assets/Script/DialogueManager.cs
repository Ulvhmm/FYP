using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

//function of displaying dialogue
public class DialogueManager : MonoBehaviour
{
    #region Singleton
    public static DialogueManager instance;
    void Awake()
    {
        instance = this;
    }
    #endregion

    Queue<string> names;
    Queue<string> sentences;

    public GameObject dialogueUI;
    public Text nameUI;
    public Text sentenceUI;


    void Start()
    {
        names = new Queue<string>();
        sentences = new Queue<string>();
    }

    public void StartDialogue(Dialogue dialogue)
    {
        names.Clear();
        sentences.Clear();

        for (int i = 0; i < dialogue.names.Length; i++)
        {
            names.Enqueue(dialogue.names[i]);
            sentences.Enqueue(dialogue.sentences[i]);
        }

        dialogueUI.SetActive(true);
        DisplayNextSentence();
    }


    public bool DisplayNextSentence()
    {

        if (names.Count == 0)
        {
            dialogueUI.SetActive(false);
            return false;
        }
        else
        {
            nameUI.text = names.Dequeue();
            sentenceUI.text = sentences.Dequeue();
            return true;
        }

    }


}

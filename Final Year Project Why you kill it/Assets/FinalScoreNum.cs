using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class FinalScoreNum : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        GetComponent<Text>().text =  "YOUR FINAL SCORE : " + ScoreManager.instance.FinalScore; 
    }

    // Update is called once per frame
    void Update()
    {
        GetComponent<Text>().text =  "YOUR FINAL SCORE : " + ScoreManager.instance.FinalScore; 
    }
}

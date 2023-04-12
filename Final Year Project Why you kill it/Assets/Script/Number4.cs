using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Number4 : MonoBehaviour
{
    void Start()
    {
        GetComponent<Text>().text =  "" + Puzzle3Manager.instance.Number4;
    }

    public void Update()
    {
        GetComponent<Text>().text =  "" + Puzzle3Manager.instance.Number4;
    }
}

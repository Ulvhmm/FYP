using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Number2 : MonoBehaviour
{
    void Start()
    {
        GetComponent<Text>().text =  "" + Puzzle3Manager.instance.Number2;
    }

    public void Update()
    {
        GetComponent<Text>().text =  "" + Puzzle3Manager.instance.Number2;
    }
}

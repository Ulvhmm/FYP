using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Number3 : MonoBehaviour
{
    void Start()
    {
        GetComponent<Text>().text =  "" + Puzzle3Manager.instance.Number3;
    }

    public void Update()
    {
        GetComponent<Text>().text =  "" + Puzzle3Manager.instance.Number3;
    }
}

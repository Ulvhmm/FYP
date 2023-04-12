using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Number1 : MonoBehaviour
{
    void Start()
    {
        GetComponent<Text>().text =  "" + Puzzle3Manager.instance.Number1;
    }

    public void Update()
    {
        GetComponent<Text>().text =  "" + Puzzle3Manager.instance.Number1;
    }
}

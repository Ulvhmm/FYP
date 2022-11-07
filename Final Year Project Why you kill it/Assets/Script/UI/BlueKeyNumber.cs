using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BlueKeyNumber : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        GetComponent<Text>().text =  "" + Player.instance.GetComponent<PlayerKeys>().Blue_Key;
    }

    public void Update()
    {
        GetComponent<Text>().text =  "" + Player.instance.GetComponent<PlayerKeys>().Blue_Key;
    }
}

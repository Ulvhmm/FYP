using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class YellowKeyNumber : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        GetComponent<Text>().text =  "" + Player.instance.GetComponent<PlayerKeys>().Yellow_Key;
    }

    public void Update()
    {
        GetComponent<Text>().text =  "" + Player.instance.GetComponent<PlayerKeys>().Yellow_Key;
    }
}

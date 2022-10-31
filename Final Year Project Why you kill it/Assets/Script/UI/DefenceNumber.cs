using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DefenceNumber : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        GetComponent<Text>().text =  "" + PlayerAttributes.instance.Defence;
    }

    public void Update()
    {
        GetComponent<Text>().text =  "" + PlayerAttributes.instance.Defence;
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UpdateHealthNum : MonoBehaviour
{
    // Update is called once per frame
    void Update()
    {
        GetComponent<Text>().text =  "+ " + TradeManager.instance.HealthValue + " HP";
    }
}

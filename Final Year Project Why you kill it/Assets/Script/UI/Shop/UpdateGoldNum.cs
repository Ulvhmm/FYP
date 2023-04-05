using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UpdateGoldNum : MonoBehaviour
{
    // Update is called once per frame
    void Update()
    {
        GetComponent<Text>().text =  "IF YOU GIVE ME " + TradeManager.instance.CurrentMoneyTotal + " GOLD, I CAN TURN IT INTO...";
    }
}

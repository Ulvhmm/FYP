using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class AttackNumber : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        GetComponent<Text>().text =  "" + Player.instance.GetComponent<PlayerAttributes>().Attack;
    }

    public void Update()
    {
        GetComponent<Text>().text =  "" + Player.instance.GetComponent<PlayerAttributes>().Attack;
    }
}

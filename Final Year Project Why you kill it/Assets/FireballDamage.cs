using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FireballDamage : MonoBehaviour
{
    public int DamageAmount;

    void OnTriggerEnter (Collider co)
    {
        DamageAmount = Mathf.RoundToInt(Player.instance.GetComponent<PlayerAttributes>().Attack * 1.2f); 

        if (co.gameObject.tag == "Enemy")
        {
            co.gameObject.GetComponent<health>().deductHealth(DamageAmount);
        }
    }
}

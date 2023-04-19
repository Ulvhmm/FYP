using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Flame : MonoBehaviour
{
    public int FireDamage = 50;

    void OnTriggerEnter()
    {
        StartCoroutine(onFire());
    }

    IEnumerator onFire()
    {
        Player.instance.GetComponent<health>().deductHealth(FireDamage);
        yield return new WaitForSeconds(1f);
        Player.instance.GetComponent<health>().deductHealth(FireDamage);
        yield return new WaitForSeconds(1f);
        Player.instance.GetComponent<health>().deductHealth(FireDamage);
        yield return new WaitForSeconds(1f);
    }
}

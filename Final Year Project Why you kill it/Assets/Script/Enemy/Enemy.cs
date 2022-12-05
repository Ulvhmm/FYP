using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : Interatable
{
    public float AttackDelay = 0.5f;

    public override void Attack()
    {
        base.Attack();

        StartCoroutine(AttackRoutine());
    }

    IEnumerator AttackRoutine()
    {
        yield return new WaitForSeconds(AttackDelay);
        GetComponent<health>().deductHealth(Player.instance.GetComponent<PlayerAttributes>().Attack);
        yield return new WaitForSeconds(AttackDelay);
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Enemyhealth : MonoBehaviour
{
    public bool isPlayer = false;
    int maxHealth = 100;
    public int Health = 500;

    public Slider HP;

    int damage;

    public int Defence = 0;

    public Animator animator;

    public void deductEnemyHealth(int AttackValue)
    {
        damage = (AttackValue - Defence);
        Health -= damage;
        Health = Mathf.Max(Health, 0);

        if (Health <= 0)
        {
            EnemyDie();
        }

    }

    IEnumerator EnemyDie()
    {
        animator.SetBool("isDead", true);
        yield return new WaitForSeconds(2f);
        Destroy(gameObject);
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class health : MonoBehaviour
{
    public bool isPlayer = false;
    int maxHealth = 100;
    public int Health = 500;
    public int EnemyDef = 0;

    public Slider HP;

    int damage;

    int PlayerDef;
    
    public void Update()
    {
        PlayerDef = Player.instance.GetComponent<PlayerAttributes>().Defence;
    }
    

    public void deductHealth(int AttackValue)
    {
        if (isPlayer)
        {
            damage = (AttackValue - PlayerDef);
            if (damage <= 0)
            {
                damage = 0;
            }
        }

        else
        {
            damage = (AttackValue - EnemyDef);
            if (damage <= 0)
            {
                damage = 0;
            }
        }

        Health -= damage;
        Health = Mathf.Max(Health, 0);

        if (Health <= 0)
        {
            if (isPlayer)
            {
                Player.instance.GetComponent<PlayerMovement>().isDead = true;
            }
            else
            {
                StartCoroutine(EnemyDie());
            }

        }

    }


    public void addHealth(int value)
    {
        Health += value;
        //Health = Mathf.Min(Health, maxHealth);
    }

    IEnumerator EnemyDie()
    {
        gameObject.GetComponent<Animator>().SetBool("isDead", true);
        gameObject.GetComponent<EnemyMovement>().attackRadius = 0f;
        gameObject.GetComponent<EnemyMovement>().alertRadius = 0f;
        gameObject.GetComponent<EnemyMovement>().movingSpeed = 0f;
        yield return new WaitForSeconds(1.5f);
        Destroy(gameObject);
    }

}

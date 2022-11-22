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
        }

        else
        {
            damage = (AttackValue - EnemyDef);
        }

        Debug.Log(damage);

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
                Destroy(gameObject);
            }

        }

    }


    public void addHealth(int value)
    {
        Health += value;
        //Health = Mathf.Min(Health, maxHealth);
    }

}

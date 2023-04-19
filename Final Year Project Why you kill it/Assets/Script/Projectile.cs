using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Projectile : MonoBehaviour
{
    public GameObject impactVFX;

    public float FireRangeTime;

    private bool collided;

    void Update()
    {
        FireRangeTime = Player.instance.GetComponent<TPSShooter>().Range;
        StartCoroutine(DestroyBullet());
    }

    void OnCollisionEnter (Collision co)
    {
        
        if (co.gameObject.tag == "Enemy")
        {
            collided = true;
            if (Player.instance.GetComponent<PlayerAttributes>().Mana < 20)
            {
                Player.instance.GetComponent<PlayerAttributes>().Mana += 2;
            }
            co.gameObject.GetComponent<health>().deductHealth(Player.instance.GetComponent<PlayerAttributes>().Attack);
            var impact = Instantiate(impactVFX, co.contacts[0].point, Quaternion.identity) as GameObject;
            Destroy(impact, 2);
            Destroy(this.gameObject);
        }

        else if(co.gameObject.tag != "Bullet" && co.gameObject.tag != "Player" && !collided)
        {
            collided = true;

            var impact = Instantiate(impactVFX, co.contacts[0].point, Quaternion.identity) as GameObject;

            Destroy(impact, 2);

            Destroy(this.gameObject);
        }

        /*
        if(co.gameObject.tag != "Bullet" && co.gameObject.tag != "Player" && !collided)
        {
            collided = true;

            var impact = Instantiate(impactVFX, co.contacts[0].point, Quaternion.identity) as GameObject;

            Destroy(impact, 2);

            Destroy (gameObject);
        }
        */

    }

    IEnumerator DestroyBullet()
    {
        yield return new WaitForSeconds(FireRangeTime);
        Destroy(this.gameObject);
    }
    
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FiregroundMovement : MonoBehaviour
{
    public float attackRadius = 5f;
    public float movingSpeed = 0f;

    public int attack = 10;
    public float CD = 0.5f;

    bool isAttacking = false;

    CharacterController characterController;

    // Start is called before the first frame update
    void Start()
    {
        characterController = GetComponent<CharacterController>();
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 playerPosition = Player.instance.transform.position;

        float distance = Vector3.Distance(playerPosition, transform.position);

        if (distance < attackRadius)
        {
            if (!isAttacking)
                {
                    isAttacking = true;
                    StartCoroutine(attackRoutine());
                }
        }

    }

    private void OnDrawGizmosSelected()
    {
        Gizmos.color = Color.red;
        Gizmos.DrawWireSphere(transform.position, attackRadius);
    }

    IEnumerator attackRoutine()
    {
        if (Vector3.Distance(transform.position, Player.instance.transform.position) < attackRadius)
        {
            Player.instance.GetComponent<health>().deductHealth(attack);
            UIManager.instance.OpenPurplePanel();
        }

        else if (Vector3.Distance(transform.position, Player.instance.transform.position) > attackRadius)
        {
            UIManager.instance.ClosePurplePanel();
        }

        yield return new WaitForSeconds(CD);
        isAttacking = false;
    }
}

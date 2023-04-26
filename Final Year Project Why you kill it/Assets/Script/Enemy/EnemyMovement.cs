using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class EnemyMovement : MonoBehaviour
{
    public float attackRadius = 5f;
    public float alertRadius = 10f;
    public float movingSpeed = 3f;

    public int attack = 10;
    public float CD = 0.5f;

    CharacterController characterController;
    Animator animator;

    bool isAttacking = false;
    bool CanMove = true;

    // Start is called before the first frame update
    void Start()
    {
        animator = GetComponent<Animator>();
        characterController = GetComponent<CharacterController>();
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 playerPosition = Player.instance.transform.position;

        float distance = Vector3.Distance(playerPosition, transform.position);

        if (distance < alertRadius)
        {
            Vector3 targetPosition = playerPosition;
            targetPosition.y = transform.position.y;
            transform.LookAt(targetPosition);

            
            if (distance < attackRadius)
            {
                //atk
                if (!isAttacking)
                {
                    isAttacking = true;
                    StartCoroutine(attackRoutine());
                }
            }

            else
            {
                if (CanMove)
                {
                    // move towards player
                    animator.SetBool("isWalking", true);

                    Vector3 movingDirection = Vector3.Normalize(playerPosition - transform.position);
                    characterController.Move(movingDirection * Time.deltaTime * movingSpeed);
                }
            }
        }
        else
        {
            animator.SetBool("isAttacking", false);
            animator.SetBool("isWalking", false);
            //jumpScarePanel.SetActive(false);
        }

    }

    private void OnDrawGizmosSelected()
    {
        Gizmos.color = Color.red;
        Gizmos.DrawWireSphere(transform.position, attackRadius);
    }

    IEnumerator attackRoutine()
    {

        animator.SetBool("isAttacking", true);
        CanMove = false;
        yield return new WaitForSeconds(0.5f);
        
        if (Vector3.Distance(transform.position, Player.instance.transform.position) < attackRadius)
        {
            Player.instance.GetComponent<health>().deductHealth(attack);
        }

        animator.SetBool("isAttacking", false);

        yield return new WaitForSeconds(CD);
        isAttacking = false;
        CanMove = true;
    }
}

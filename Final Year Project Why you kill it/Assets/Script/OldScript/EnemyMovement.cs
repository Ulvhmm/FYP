using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class EnemyMovement : MonoBehaviour
{
    public float attackRadius = 5f;
    public float alertRadius = 10f;
    public float movingSpeed = 3f;

    CharacterController characterController;
    Animator animator;

    // Start is called before the first frame update
    void Start()
    {
        animator = GetComponent<Animator>();
        characterController = GetComponent<CharacterController>();
        //scarePanel.instance.OpenScarePanel();
        //jumpScarePanel = GameObject.Find("ScarePanel"); // jump scare | find gameobject from prefab
        //jumpScarePanel = GetComponent<GameObject>();
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
                SceneManager.LoadScene(4);
            }
            else
            {
                // move towards player
                animator.SetBool("isWalking", true);

                Vector3 movingDirection = Vector3.Normalize(playerPosition - transform.position);
                characterController.Move(movingDirection * Time.deltaTime * movingSpeed);
            }
        }
        else
        {
            animator.SetBool("isWalking", false);
            //jumpScarePanel.SetActive(false);
        }

    }
}

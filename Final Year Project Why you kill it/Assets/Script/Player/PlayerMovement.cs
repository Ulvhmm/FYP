using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public CharacterController controller;
    public Transform cam;
    public Animator animator;

    Vector3 playerVelocity;
    float gravityForce = -20f;
    public float speed = 6f;

    public float turnSmoothTime = 0.1f;
    float turnSmoothVelocity;

    public bool isAttacking = false;
    public float atkRadius = 2f;
    public int attack;

    public bool isDead = false;
    public bool canMove = true;

    void Start()
    {
        attack = Player.instance.GetComponent<PlayerAttributes>().Attack;
    }

    // Update is called once per frame
    void Update()
    {
        //movement
        float horizontal = Input.GetAxisRaw("Horizontal");
        float vertical = Input.GetAxisRaw("Vertical");
        Vector3 direction = new Vector3(horizontal, 0f, vertical).normalized;

        if(canMove && direction.magnitude >= 0.1f)
        {
            float targetAngle = Mathf.Atan2(direction.x, direction.z) * Mathf.Rad2Deg + cam.eulerAngles.y; ;
            float angle = Mathf.SmoothDampAngle(transform.eulerAngles.y, targetAngle, ref turnSmoothVelocity, turnSmoothTime);
            transform.rotation = Quaternion.Euler(0f, angle, 0f);

            Vector3 moveDir = Quaternion.Euler(0f, targetAngle, 0f) * Vector3.forward;
            controller.Move(moveDir.normalized * speed * Time.deltaTime);
        }

        //attack
        if (canMove && Input.GetKeyDown(KeyCode.Mouse0) && isAttacking == false)
        {
            isAttacking = true;
            canMove = false;
            animator.SetBool("isAttacking", true);
            StartCoroutine(Attacking());
        }

        //walking
        if (canMove && Input.GetAxis("Vertical") != 0 | Input.GetAxis("Horizontal") != 0)
        {
            animator.SetBool("isWalking", true);
        }
        else 
        { 
            animator.SetBool("isWalking", false); 
        }

        //die
        if (isDead == true)
        {
            //animator.SetBool("isDead", true);
        }

        //isGrounded check
        if (controller.isGrounded)
        {
            playerVelocity.y = 0f;
        }
        playerVelocity.y += gravityForce * Time.deltaTime;

        controller.Move(playerVelocity * Time.deltaTime);
    }

    private void OnDrawGizmosSelected()
    {
        Gizmos.color = Color.red;
        Gizmos.DrawWireSphere(transform.position, atkRadius);
    }

    IEnumerator Attacking()
    {
        animator.SetBool("isAttacking", true);
        yield return new WaitForSeconds(1.3f);
        animator.SetBool("isAttacking", false);
        isAttacking = false;
        canMove = true;
    }
}

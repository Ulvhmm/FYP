using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Interatable : MonoBehaviour
{
    public float interactableRadius = 2;
    public float interactableAngle = 50;
    private bool isAttacking = false;

    Transform player;

    //public GameObject InteractionButton;

    // Start is called before the first frame update
    void Start()
    {
        player = Player.instance.transform;
    }

    // Update is called once per frame
    void Update()
    {
        float distance = Vector3.Distance(transform.position, player.position);

        Vector3 objectDirection = transform.position - player.position;
        Vector3 playerDirection = player.forward;
        float angle = Vector3.Angle(objectDirection, playerDirection);

        if (distance < interactableRadius && angle < interactableAngle && Input.GetKeyDown(KeyCode.Space))
        {
            //InteractionButton.SetActive(true);
            Interact();
        }

        else
        {
            //InteractionButton.SetActive(false);
        }

        /*
        if (distance < interactableRadius && angle < interactableAngle && Input.GetMouseButtonDown(0) && isAttacking == false)
        {
            Attack();
            StartCoroutine(CoolDown());
        }
        */

        if (Input.GetMouseButtonDown(0) && isAttacking == false)
        {
            Attack();
            StartCoroutine(CoolDown());
        }
    }

    public virtual void Interact()
    {
        Debug.Log("Interacted with " + transform.name);
    }

    public virtual void Attack()
    {
        Debug.Log("Attacking " + transform.name);
    }

    private void OnDrawGizmosSelected()
    {
        Gizmos.color = Color.yellow;
        Gizmos.DrawWireSphere(transform.position, interactableRadius);
    }

    IEnumerator CoolDown()
    {
        isAttacking = true;
        yield return new WaitForSeconds(1f);
        isAttacking = false;
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Interactable : MonoBehaviour
{
    public float interactableRadius = 5;
    public float interactableAngle = 80;

    public GameObject BannerForInteractables;

    Transform player;

    // Start is called before the first frame update
    void Start()
    {
        player = GameObject.Find("Player").transform;
    }

    // Update is called once per frame
    void Update()
    {
        float distance = Vector3.Distance(transform.position, player.position);

        Vector3 objectDirection = transform.position - player.position;
        Vector3 playerDirection = player.forward;
        float angle = Vector3.Angle(objectDirection, playerDirection);

        if (distance < interactableRadius && angle < interactableAngle)  //show banner
        {
            BannerForInteractables.SetActive(true);
        }
        else
        {
            BannerForInteractables.SetActive(false);
        }

        if (distance < interactableRadius && angle < interactableAngle && Input.GetKeyDown(KeyCode.E))   // press "E" to interact with objects
        {
            Interact();
            BannerForInteractables.SetActive(false);
        }
    }

    // virtual function
    public virtual void Interact()
    {
        Debug.Log("Interactable" + transform.name);
    }

    private void OnDrawGizmosSelected()
    {
        Gizmos.color = Color.yellow;
        Gizmos.DrawWireSphere(transform.position, interactableRadius);
    }
}

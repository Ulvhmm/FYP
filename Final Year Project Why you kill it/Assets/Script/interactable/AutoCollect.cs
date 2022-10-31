using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AutoCollect : MonoBehaviour
{
    public float interactableRadius = 2;

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

        if (distance < interactableRadius)
        {
            Interact();
        }
    }

    // virtual function
    public virtual void Interact()
    {
        Debug.Log("Interactable" + transform.name);
    }

    private void OnDrawGizmosSelected()
    {
        Gizmos.color = Color.red;
        Gizmos.DrawWireSphere(transform.position, interactableRadius);
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FireballMovement : MonoBehaviour
{
    public float attackRadius = 5f;
    public float alertRadius = 10f;
    public float movingSpeed = 3f;

    public int attack = 10;

    public float lifetime = 15.0f;
    private float elapsedTime = 0.0f;

    CharacterController characterController;

    public GameObject ExplosionPrefab;

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

        if (distance < alertRadius)
        {
            // move towards player
            Vector3 movingDirection = Vector3.Normalize(playerPosition - transform.position);
            characterController.Move(movingDirection * Time.deltaTime * movingSpeed);

            
            if (distance < attackRadius)
            {
                Instantiate(ExplosionPrefab, transform.position, Quaternion.identity);
                Player.instance.GetComponent<health>().deductHealth(attack);
                Destroy(gameObject);
            }
        }

        // Increment the elapsed time
        elapsedTime += Time.deltaTime;

        // Check if the elapsed time has exceeded the lifetime
        if (elapsedTime >= lifetime)
        {
            // Destroy the ability game object
            Destroy(gameObject);
        }
    }

    private void OnDrawGizmosSelected()
    {
        Gizmos.color = Color.red;
        Gizmos.DrawWireSphere(transform.position, attackRadius);
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IceStorm : MonoBehaviour
{
    public float attackRadius = 15f;
    public float movingSpeed = 0f;

    public int attack = 100;

    public float lifetime = 10.0f;
    private float awakeTime = 5f;
    private float elapsedTime = 0.0f;

    public float healthDecreaseInterval = 0.5f;
    private float timer;

    private bool isActive = false;

    // Update is called once per frame
    void Update()
    {
        Vector3 playerPosition = Player.instance.transform.position;

        float distance = Vector3.Distance(playerPosition, transform.position);

        if (isActive && distance < attackRadius)
        {
            // Update timer
            timer += Time.deltaTime;

            // Check if interval has passed
            if (timer >= healthDecreaseInterval)
            {
                // Decrease health
                Player.instance.GetComponent<health>().deductHealth(attack);

                // Reset timer
                timer = 0f;
            }
        }

        // Increment the elapsed time
        elapsedTime += Time.deltaTime;

        if (elapsedTime >= awakeTime)
        {
            isActive = true;
        }

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

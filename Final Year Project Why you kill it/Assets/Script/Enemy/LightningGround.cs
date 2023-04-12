using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LightningGround : MonoBehaviour
{
    public float attackRadius = 5f;
    public float movingSpeed = 0f;

    public int attack = 100;

    public float lifetime = 15.0f;
    private float awakeTime = 3f;
    private float elapsedTime = 0.0f;

    private bool isActive = false;

    public GameObject LightningPrefab;

    // Update is called once per frame
    void Update()
    {
        Vector3 playerPosition = Player.instance.transform.position;

        float distance = Vector3.Distance(playerPosition, transform.position);

        Quaternion quaternion = Quaternion.Euler(-90f, 90, 90f);

        if (isActive && distance < attackRadius)
        {
            Instantiate(LightningPrefab, transform.position, quaternion);
            Player.instance.GetComponent<health>().deductHealth(attack);
            Destroy(gameObject);
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

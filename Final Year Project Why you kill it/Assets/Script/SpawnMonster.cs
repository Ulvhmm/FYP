using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnMonster : MonoBehaviour
{
    public GameObject Monster;

    void OnTriggerEnter()
    {
        Monster.SetActive(true);

        Destroy(this.gameObject);
    }
}

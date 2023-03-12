using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class summonBoss : MonoBehaviour
{
    public GameObject Boss;

    public AudioClip Clip1;
    public AudioSource Source;

    void OnTriggerEnter()
    {
        Boss.SetActive(true);
        Source.PlayOneShot(Clip1, 0.8f);

        Destroy(this.gameObject);
    }
}

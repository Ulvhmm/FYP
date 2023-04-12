using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class summonBoss : MonoBehaviour
{
    public GameObject Boss;

    public AudioClip Clip1;
    public AudioSource Source;

    public GameObject bossIntro;

    void OnTriggerEnter()
    {
        Boss.SetActive(true);
        Source.PlayOneShot(Clip1, 0.5f);
        bossIntro.SetActive(true);

        Destroy(this.gameObject);
    }
}

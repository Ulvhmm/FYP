using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Boss : MonoBehaviour
{
    #region Singleton
    public static Boss instance;

    // first function called in script 
    void Awake()
    {
        instance = this;
    }
    #endregion

    public int NumberOfGhostFire = 2;
    public int NumberOfLightning = 2;

    public GameObject GhostFire; 
    public GameObject LightningGround; 
    public GameObject IceStormGround;
    public GameObject IceStormVFX;

    public bool ReadytoCast = true;

    void Start()
    {
        StartCoroutine(CastingAbility());
    }

    void update()
    {

    }

    public void CastSecondAbility()
    {
        StartCoroutine(CastingAbility());
    }

    IEnumerator CastingAbility()
    {
        if (ReadytoCast)
        {
            yield return new WaitForSeconds(5);

            int caseSwitch = Random.Range(1, 4);
            Debug.Log(caseSwitch);

            switch (caseSwitch)
            {
            case 1:
                StartCoroutine(SummonGhostFire());
                break;
            case 2:
                StartCoroutine(SummonLightning());
                break;
            case 3:
                StartCoroutine(SummonIceStormGround());
                break;
            }
        }
    }

    // Start is called before the first frame update
    IEnumerator SummonGhostFire()
    {
        ReadytoCast = false;
        Debug.Log("Casting Fireball");

        for (int i = 0; i < NumberOfGhostFire; i++)
        {
            Vector3 position = new Vector3(Random.Range(-17f, 17f), 75f, Random.Range(70f, 90f));
            Quaternion quaternion = Quaternion.Euler(-90f, 90, 90f);
            Instantiate(GhostFire, position, quaternion);
        }

        yield return new WaitForSeconds(5);
        ReadytoCast = true;
        StartCoroutine(CastingAbility());
    }

    IEnumerator SummonLightning()
    {
        ReadytoCast = false;
        Debug.Log("Casting Lightning");

        for (int i = 0; i < NumberOfLightning; i++)
        {
            Vector3 position = new Vector3(Random.Range(-17f, 17f), 68.6f, Random.Range(65f, 95f));
            Quaternion quaternion = Quaternion.Euler(-90f, 90, 90f);
            Instantiate(LightningGround, position, quaternion);
        }

        yield return new WaitForSeconds(5);
        ReadytoCast = true;
        StartCoroutine(CastingAbility());
    }

    IEnumerator SummonIceStormGround()
    {
        ReadytoCast = false;
        Debug.Log("Casting IceStorm");

        Vector3 position = new Vector3(Random.Range(-17f, 17f), 68.6f, Random.Range(65f, 95f));
        Quaternion quaternion = Quaternion.Euler(-90f, 90, 90f);
        Instantiate(IceStormGround, position, quaternion);
        position += new Vector3(0f, 15f, 0f);

        yield return new WaitForSeconds(5);
        Quaternion quaternion2 = Quaternion.Euler(90f, 0f, 0f);
        Instantiate(IceStormVFX, position, quaternion2);
        ReadytoCast = true;
        StartCoroutine(CastingAbility());
    }
}

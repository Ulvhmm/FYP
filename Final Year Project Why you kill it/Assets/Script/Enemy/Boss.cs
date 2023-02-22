using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Boss : MonoBehaviour
{
    public int NumberOfFireball = 2;
    public int NumberOfFireground = 2;

    public GameObject Fireball; 
    public GameObject Fireground; 

    public bool ReadytoCast = true;

    void Start()
    {
        StartCoroutine(CastingAbility());
    }

    void Awake()
     {

     }

     void update()
     {
        
     }

     IEnumerator CastingAbility()
    {
        if (ReadytoCast)
        {
            yield return new WaitForSeconds(5);

            int caseSwitch = Random.Range(1, 2);
            Debug.Log(caseSwitch);

            switch (caseSwitch)
            {
            case 1:
                StartCoroutine(SummonFireball());
                break;
            case 2:
                StartCoroutine(SummonFireground());
                break;
            }
        }
    }

    // Start is called before the first frame update
    IEnumerator SummonFireball()
    {
        ReadytoCast = false;
        Debug.Log("Casting Fireball");

        for (int i = 0; i < NumberOfFireball; i++)
        {
            Vector3 position = new Vector3(Random.Range(-13f, 13f), 75f, Random.Range(70f, 90f));
            Quaternion quaternion = Quaternion.Euler(-90f, 90, 90f);
            Instantiate(Fireball, position, quaternion);
        }

        yield return new WaitForSeconds(5);
        ReadytoCast = true;
        StartCoroutine(CastingAbility());
    }

    IEnumerator SummonFireground()
    {
        ReadytoCast = false;
        Debug.Log("Casting Fireground");

        for (int i = 0; i < NumberOfFireground; i++)
        {
            Vector3 position = new Vector3(Random.Range(-13f, 13f), 69.5f, Random.Range(70f, 90f));
            Quaternion quaternion = Quaternion.Euler(-90f, 90, 90f);
            Instantiate(Fireground, position, quaternion);
        }

        yield return new WaitForSeconds(5);
        ReadytoCast = true;
        StartCoroutine(CastingAbility());
    }
}

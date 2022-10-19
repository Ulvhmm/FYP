using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InteractableManager : MonoBehaviour
{
    public int numberOfMaleZombies;
    public GameObject maleZombie; 

    // Start is called before the first frame update
    void Start()
    {
        // number male zombie prefab
        for (int i = 0; i < numberOfMaleZombies; i++)
        {
            Vector3 position = new Vector3(Random.Range(-350f, 350f), 0f, Random.Range(-350f, 350f));
            Quaternion quaternion = Quaternion.Euler(0f, Random.Range(0, 359), 0f);
            Instantiate(maleZombie, position, quaternion);
        }
    }
}

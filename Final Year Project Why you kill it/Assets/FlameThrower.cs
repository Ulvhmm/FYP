using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FlameThrower : MonoBehaviour
{
    public GameObject FlamePrefab;
    public Transform FirePoint;

    public float Y_angle;

    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(InstantiateProjectile());
    }

    // Update is called once per frame
    void Update()
    {

    }

    IEnumerator InstantiateProjectile()
    {
        Quaternion quaternion = Quaternion.Euler(0f, Y_angle, 0f);
        var projectileObj = Instantiate(FlamePrefab, FirePoint.position, quaternion) as GameObject;
        yield return new WaitForSeconds(3f);
        Destroy(projectileObj);
        yield return new WaitForSeconds(3f);
        StartCoroutine(InstantiateProjectile());
    }
}

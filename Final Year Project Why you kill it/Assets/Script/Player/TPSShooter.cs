using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TPSShooter : MonoBehaviour
{
    public Camera cam;
    public GameObject ViewPoint;
    public GameObject projectile;
    public Transform FirePoint;
    public float projectileSpeed = 10;
    public float FireRate = 4;

    public float Range = 0.2f;

    private Vector3 destination;
    private float timeToFire;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    /*
    // Update is called once per frame
    void Update()
    {
        if(Input.GetMouseButtonDown(0) && Time.time >= timeToFire)
        {
            timeToFire = Time.time + 1/FireRate;
            ShootProjectile();
        }
    }
    */

    public void Shooting()
    {
        if(Time.time >= timeToFire)
        {
            timeToFire = Time.time + 1/FireRate;
            ShootProjectile();
        }
    }

    void ShootProjectile()
    {
        Ray ray = cam.ViewportPointToRay(new Vector3(0.5f, 0.5f, 0));
        RaycastHit hit;

        if(Physics.Raycast(ray, out hit))
            destination = hit.point;
        else
            destination = ray.GetPoint(10);

        InstantiateProjectile();
    }

    void InstantiateProjectile()
    {
        var projectileObj = Instantiate(projectile, FirePoint.position, Quaternion.identity) as GameObject;
        projectileObj.GetComponent<Rigidbody>().velocity = (destination - FirePoint.position).normalized * projectileSpeed;
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class interactableManager : MonoBehaviour
{
    #region Singleton
    public static interactableManager instance;
    void Awake()
    {
        instance = this;
    }
    #endregion

    public GameObject item1Prefab, item2Prefab, item3Prefab, enemyPrefab;
    public Transform item1P, item2P, item3P, enemyP;
    public int noOfi1, noOfi2, noOfi3, noOfEnemies;
    int x1, x2, z1, z2;


    // Start is called before the first frame update
    void Start()
    {

        #region array & switch the random size (x1,x2,y1,y2)

        int[] v = {-130,-20,-150,0, -120,100,0,-250, -250,350,300,-250};

        int nowLv = PlayerPrefs.GetInt("nowlv");
        Debug.Log("nowlv=" + nowLv);
        x1 = v[0];
        x2 = v[1];
        z1 = v[2];
        z2 = v[3];
        switch (nowLv)
        {
            case 0:
                x1 = v[0];
                x2 = v[1];
                z1 = v[2];
                z2 = v[3];
                break;
            case 1:
                x1 = v[4];
                x2 = v[5];
                z1 = v[6];
                z2 = v[7];
                break;
            case 2:
                x1 = v[4];
                x2 = v[5];
                z1 = v[6];
                z2 = v[7];
                break;
            case 3:
                x1 = v[8];
                x2 = v[9];
                z1 = v[10];
                z2 = v[11];
                break;

        }


        #endregion

        for (int i = 0; i < noOfi1; i++)
        {
            Vector3 position = new Vector3(Random.Range(x1, x2), 0.6f, Random.Range(z1, z2));
            Quaternion quaternion = Quaternion.Euler(0, Random.Range(0, 359), 0);
            Instantiate(item1Prefab, position, quaternion, item1P);
        }

        for (int i = 0; i < noOfi2; i++)
        {
            Vector3 position = new Vector3(Random.Range(x1, x2), 1f, Random.Range(z1, z2));
            Quaternion quaternion = Quaternion.Euler(0, Random.Range(0, 359), 0);
            Instantiate(item2Prefab, position, quaternion, item2P);
        }

        for (int i = 0; i < noOfi3; i++)
        {
            Vector3 position = new Vector3(Random.Range(x1, x2), 2f, Random.Range(z1, z2));
            Quaternion quaternion = Quaternion.Euler(0, Random.Range(0, 359), 0);
            Instantiate(item3Prefab, position, quaternion, item3P);
        }

        for (int i = 0; i < noOfEnemies; i++)
        {
            Vector3 position = new Vector3(Random.Range(x1, x2), 0.5f, Random.Range(z1, z2));
            Quaternion quaternion = Quaternion.Euler(0, Random.Range(0, 359), 0);
            Instantiate(enemyPrefab, position, quaternion, enemyP);
        }
    }

    public void respawnEnemy()
    {
        Vector3 position = new Vector3(Random.Range(x1, x2), 0.5f, Random.Range(z1, z2));
        Quaternion quaternion = Quaternion.Euler(0, Random.Range(0, 359), 0);
        Instantiate(enemyPrefab, position, quaternion, enemyP);

    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LevelSwitcher : MonoBehaviour
{
    
   // int i = 0;
    public GameObject stage1;
    public GameObject stage2;
    //public GameObject[] stages = new GameObject[1]{stage1};

    // Start is called before the first frame update
    void Start()
    {
        Vector3 position = new Vector3(0f, 0f, 0f);
        Quaternion quaternion = Quaternion.Euler(0f, 0f, 0f);
        Instantiate(stage1,position,quaternion);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void GenerateNewStage(){

    }
}

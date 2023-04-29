using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScoreManager : MonoBehaviour
{
    public static ScoreManager instance;

    public int HealthNum;
    public int YellowKeyNum;
    public int BlueKeyNum;

    public int FinalScore;
 
    private void Awake()
    {
        if (instance == null)
        {
            instance = this;
            DontDestroyOnLoad(gameObject);
        }
        else
        {
            Destroy(gameObject);
        }
    }

    void Update()
    {
        HealthNum = Player.instance.GetComponent<health>().Health;
        YellowKeyNum = Player.instance.GetComponent<PlayerKeys>().Yellow_Key;
        BlueKeyNum = Player.instance.GetComponent<PlayerKeys>().Blue_Key;

        FinalScore = HealthNum * 10 + YellowKeyNum * 1000 + BlueKeyNum * 3000;
    }
}

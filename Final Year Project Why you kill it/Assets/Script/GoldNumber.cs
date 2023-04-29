using UnityEngine;
using UnityEngine.UI;

public class GoldNumber : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
       GetComponent<Text>().text =  Player.instance.GetComponent<PlayerAttributes>().Gold + "   GOLD"; 
    }

    // Update is called once per frame
    void Update()
    {
        GetComponent<Text>().text =  Player.instance.GetComponent<PlayerAttributes>().Gold + "   GOLD"; 
    }
}

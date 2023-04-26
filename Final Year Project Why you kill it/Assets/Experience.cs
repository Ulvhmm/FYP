using UnityEngine;
using UnityEngine.UI;

public class Experience : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        GetComponent<Text>().text =  "" + Player.instance.GetComponent<PlayerAttributes>().Experience + "/" + Player.instance.GetComponent<PlayerAttributes>().RequireXP;
    }

    // Update is called once per frame
    void Update()
    {
        GetComponent<Text>().text =  "" + Player.instance.GetComponent<PlayerAttributes>().Experience + "/" + Player.instance.GetComponent<PlayerAttributes>().RequireXP;
    }
}

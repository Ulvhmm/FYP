using UnityEngine;
using UnityEngine.UI;

public class MPNumber : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        GetComponent<Text>().text =  "" + Player.instance.GetComponent<PlayerAttributes>().Mana + "/20";
    }

    public void Update()
    {
        GetComponent<Text>().text =  "" + Player.instance.GetComponent<PlayerAttributes>().Mana + "/20";
    }
}

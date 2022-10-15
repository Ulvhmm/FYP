using UnityEngine;

public class billboard : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        transform.LookAt(Camera.main.transform);
    }

    // Update is called once per frame
    void Update()
    {
        transform.LookAt(Camera.main.transform);
    }
}

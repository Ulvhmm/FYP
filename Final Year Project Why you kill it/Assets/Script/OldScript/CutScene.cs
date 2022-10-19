using UnityEngine;
using UnityEngine.SceneManagement;

public class CutScene : MonoBehaviour
{
    void OnEnable()
    {
        SceneManager.LoadScene(2);
    }
}

using UnityEngine;
using UnityEngine.SceneManagement;

public class HomePageSceneLoader : MonoBehaviour
{
    void OnEnable()
    {
        SceneManager.LoadScene(0);
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class BadEndingUIManager : MonoBehaviour
{
    public void RestartGame()
    {
        SceneManager.LoadScene(2);
    }

    public void BackToHomePage()
    {
        SceneManager.LoadScene(0);
    }

    public void update()
    {
        Cursor.visible = true;
    }
}

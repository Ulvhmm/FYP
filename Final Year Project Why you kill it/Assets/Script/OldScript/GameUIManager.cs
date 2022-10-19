using UnityEngine;
using UnityEngine.SceneManagement;

public class GameUIManager : MonoBehaviour
{
    public GameObject escapePanel;

    private void Update()
    {
        // game menu
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            escapePanel.SetActive(!escapePanel.activeSelf);
        }
    }

    public void RestartGame()
    {
        SceneManager.LoadScene(1);
    }

    public void BackToHomePage()
    {
        SceneManager.LoadScene(0);
    }

    public void QuitGame()
    {
        Application.Quit();
    }

    public void CloseEscapePanel()
    {
        escapePanel.SetActive(!escapePanel.activeSelf);
    }

}

using UnityEngine;
using UnityEngine.SceneManagement;

public class UIManager : MonoBehaviour
{
    public GameObject startButton;
    public GameObject quitButton;

    public GameObject settingsButton;
    public GameObject SettingsDialog;

    public GameObject instructionButton;
    public GameObject instructionPage;

    // scene change
    public void StartGame()
    {
        SceneManager.LoadScene(1);
    }

    // lock/unlock mouse cursor
    void Update()
    {
        Cursor.lockState = CursorLockMode.None;
        Cursor.visible = true;
    }
    
    public void OpenSettings()
    {
        startButton.SetActive(false);
        settingsButton.SetActive(false);
        quitButton.SetActive(false);
        instructionButton.SetActive(false);
        SettingsDialog.SetActive(true);
    }

    public void CloseSettings()
    {
        startButton.SetActive(true);
        settingsButton.SetActive(true);
        quitButton.SetActive(true);
        instructionButton.SetActive(true);
        SettingsDialog.SetActive(false);
    }

    public void OpenInstructionMenu()
    {
        startButton.SetActive(false);
        settingsButton.SetActive(false);
        quitButton.SetActive(false);
        instructionButton.SetActive(false);
        instructionPage.SetActive(true);
    }


    public void CloseInstructionMenu()
    {
        startButton.SetActive(true);
        settingsButton.SetActive(true);
        quitButton.SetActive(true);
        instructionButton.SetActive(true);
        instructionPage.SetActive(false);
    }

    public void QuitGame()
    {
        Application.Quit();
    }
}

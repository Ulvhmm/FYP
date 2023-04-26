using UnityEngine;
using UnityEngine.SceneManagement;

public class UIManager : MonoBehaviour
{
    #region Singleton
    public static UIManager instance;

    // first function called in script 
    void Awake()
    {
        instance = this;
    }

    #endregion

    public GameObject EscapePanel;

    public GameObject MainMenu;
    public GameObject SubMenu;

    public GameObject SettingButtons;
    public GameObject Settings;

    public GameObject Guidebook;

    public GameObject ContributorDialog;

    public GameObject ScorePage;
    public GameObject DialogObject;
    public GameObject SkipObject;
    public GameObject BackObject;

    // scene change
    public void StartGame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }

    public void BackToHomePage()
    {
        SceneManager.LoadScene("TitleScreen");
    }

    public void RestartGame()
    {
        SceneManager.LoadScene("Main");
    }

    public void OpenSettings()
    {
        EscapePanel.SetActive(true);
    }

    public void CloseSettings()
    {
        EscapePanel.SetActive(false);
    }

    public void OpenContributorDialog()
    {
        ContributorDialog.SetActive(true);
    }

    public void CloseContributorDialog()
    {
        ContributorDialog.SetActive(false);
    }

    public void QuitGame()
    {
        Application.Quit();
    }

    // Game UI
    public void OpenEscapePanel()
    {
        EscapePanel.SetActive(true);
    }

    public void CloseEscapePanel()
    {
        EscapePanel.SetActive(false);
        Cursor.lockState = CursorLockMode.Locked;
        Cursor.visible = false;
        Time.timeScale = 1;
    }

    public void OpenGame()
    {
        SubMenu.SetActive(false);
    }

    public void BackToMenu()
    {
        SubMenu.SetActive(false);
    }

    public void OpenGameSettings()
    {
        Settings.SetActive(true);
    }

    public void CloseGameSettings()
    {
        Settings.SetActive(false);
    }

    public void OpenGuidebook()
    {
        Guidebook.SetActive(true);
    }

     public void CloseGuidebook()
    {
        Guidebook.SetActive(false);
    }

    public void SkipEnding()
    {
        ScorePage.SetActive(true);
        DialogObject.SetActive(false);
        SkipObject.SetActive(false);
        BackObject.SetActive(true);
    }
}

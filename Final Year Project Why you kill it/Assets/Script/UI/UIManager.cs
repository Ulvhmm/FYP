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

    public GameObject SettingsDialog;

    public GameObject SettingButtons;
    public GameObject Settings;
    public GameObject ContributorDialog;

    // scene change
    public void StartGame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }

    public void RestartGame()
    {
        SceneManager.LoadScene(2);
    }

    public void OpenSettings()
    {
        SettingsDialog.SetActive(true);
    }

    public void OpenGameSettings()
    {
        SettingButtons.SetActive(false);
        Settings.SetActive(true);
    }

    public void CloseGameSettings()
    {
        SettingButtons.SetActive(true);
        Settings.SetActive(false);
    }

    public void CloseSettings()
    {
        SettingsDialog.SetActive(false);
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
}

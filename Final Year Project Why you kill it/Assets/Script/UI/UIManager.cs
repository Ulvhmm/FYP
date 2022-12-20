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
    public GameObject ContributorDialog;

    // scene change
    public void StartGame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }
    
    public void OpenSettings()
    {
        SettingsDialog.SetActive(true);
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

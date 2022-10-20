using UnityEngine;
using UnityEngine.SceneManagement;

public class UIManager : MonoBehaviour
{
    public GameObject SettingsDialog;
    public GameObject ContributorDialog;

    // scene change
    public void StartGame()
    {
        SceneManager.LoadScene(1);
    }

    /*
    // lock/unlock mouse cursor
    void Update()
    {
        Cursor.lockState = CursorLockMode.None;
        Cursor.visible = true;
    }
    */
    
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

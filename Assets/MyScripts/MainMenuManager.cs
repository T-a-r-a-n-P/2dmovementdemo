using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenuManager : MonoBehaviour
{
    public GameObject optionsMenuUI;
    public GameObject mainMenuUI;

    public void Start()
    {
        optionsMenuUI.SetActive(false);
    }

    public void LoadScene(string sceneName)
    {
        SceneManager.LoadScene(sceneName);
    }
    
    public void QuitGame()
    {
        Debug.Log("Quitting game");
        Application.Quit();
    }

    public void Options()
    {
        optionsMenuUI.SetActive(true);
        mainMenuUI.SetActive(false);

    }

    public void quitOptions()
    {
        optionsMenuUI.SetActive(false);
        mainMenuUI.SetActive(true);
    }
}

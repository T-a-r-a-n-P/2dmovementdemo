using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenuManager : MonoBehaviour
{
    public AudioSource myAudio;
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
    public void maxVol()
    {
        myAudio.volume = 1.0f;
    }
    public void vol2()
    {
        myAudio.volume = 0.66f;
    }
    public void vol3()
    {
        myAudio.volume = 0.33f;
    }
    public void minVol()
    {
        myAudio.volume = 0.0f;
    }
}

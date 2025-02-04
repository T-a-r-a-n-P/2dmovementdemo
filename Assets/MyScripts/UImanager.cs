using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UImanager : MonoBehaviour
{
    public GameObject pauseMenuUI;
    public GameObject optionsMenuUI;
    public static bool isPaused = false;

    void Start()
    {
        pauseMenuUI.SetActive(false);
        optionsMenuUI.SetActive(false);
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            if (isPaused) ResumeGame();
            else PauseGame();
        }
    }

    public void ResumeGame()
    {
        pauseMenuUI.SetActive(false);
        Time.timeScale = 1f;
        isPaused = false;
    }

    void PauseGame()
    {
        pauseMenuUI.SetActive(true);
        Time.timeScale = 0f;
        isPaused = true;
    }

    public void QuitGame()
    {
        Debug.Log("Quitting the game");
        Application.Quit();
    }

    public void Options()
    {
        optionsMenuUI.SetActive(true);
        pauseMenuUI.SetActive(false);
    }

    public void quitOptions()
    {
        optionsMenuUI.SetActive(false);
        pauseMenuUI.SetActive(true);
    }
}

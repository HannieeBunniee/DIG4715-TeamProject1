using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class PauseMenu : MonoBehaviour
{
    public static bool GameIsPaused = false;
    public static bool winLoseCondition = false;
    public GameObject pauseMenuUI;
    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape) && winLoseCondition == false)
        {
            if (GameIsPaused)
            {
                Resume();
            }
            else
            {
                Pause();
            }
        }
    }

    public void Resume()
    {
        pauseMenuUI.SetActive(false);
        Time.timeScale = 1f; //unfreeze the game
        GameIsPaused = false;
    }

    void Pause()
    {
        pauseMenuUI.SetActive(true);
        Time.timeScale = 0f; //freeze the game
        GameIsPaused = true;
    }

    public void LoadMenu()
    {
        //Debug.Log("Loading Menu");
        SceneManager.LoadScene("MainMenu");
    }

    public void QuitGame()
    {
        Debug.Log("quitting game");
        Application.Quit();
    }

    public void RestartGame()
    {
        Time.timeScale = 1f; //unfreeze the game
        SceneManager.LoadScene("ContraGameLevel");
    }
}

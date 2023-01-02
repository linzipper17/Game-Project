using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Serialization;
using UnityEngine.SceneManagement;

public class UIControl : MonoBehaviour
{
    public static bool isPaused = false, isControlling = false;
    public GameObject pauseMenuUI;
    public GameObject controlMenuUI;

    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Escape))
        {
            if(isPaused)
            {
                Resume();
            }
            else if (isControlling)
            {
                Pause();
            }
            else
            {
                Pause();
            }
        }
    }

    #region PauseMenu

    public void Pause()
    {
        pauseMenuUI.SetActive(true);
        Time.timeScale = 0f;
        isPaused = true;
    }

    public void Resume()
    {
        pauseMenuUI.SetActive(false);
        Time.timeScale = 1f;
        isPaused = false;
    }

    #endregion

    #region Controls

    public void ControlButtonClicked()
    {
        isControlling = true;
        isPaused = false;
    }

    #endregion
    
    public void ReturnToMenu()
    {
        SceneManager.LoadScene(0, LoadSceneMode.Single);
    }
}

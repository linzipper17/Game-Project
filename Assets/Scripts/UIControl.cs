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
        controlMenuUI.SetActive(false);
        Time.timeScale = 0f;
        isPaused = true;
        isControlling = false;
    }

    public void Resume()
    {
        pauseMenuUI.SetActive(false);
        controlMenuUI.SetActive(false);
        Time.timeScale = 1f;
        isPaused = false;
        isControlling = false;
    }

    #endregion

    #region Controls

    public void ControlButtonClicked()
    {
        controlMenuUI.SetActive(true);
        pauseMenuUI.SetActive(false);
        isControlling = true;
        isPaused = false;
    }

    #endregion
    
    public void ReturnToMenu()
    {
        SceneManager.LoadScene(0, LoadSceneMode.Single);
    }
}

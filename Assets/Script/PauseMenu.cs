using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PauseMenu : MonoBehaviour{

    public static bool GameIsPaused = true;
    
    public GameObject pauseMenuUI;

    public GameObject CompleteLevel1UI; 

    public GameObject CompleteLevel2UI; 


    // Update is called once per frame
    void Update()  {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            if (GameIsPaused)
            {
                Resume();
            } else
            {
                Pause();
            }
        }
    }   

    public void Resume ()
    {
        pauseMenuUI.SetActive(false);
        Time.timeScale = 1f;
        GameIsPaused = false;
    } 
    public void CompleteLevel1()
    {
        Debug.Log("player 2 win");
        CompleteLevel2UI.SetActive(true);
    } 
    public void CompleteLevel2()
    {
        Debug.Log("player 1 win");
        CompleteLevel1UI.SetActive(true);
    }
    public void Restart ()
    {
        pauseMenuUI.SetActive(false);
        Time.timeScale = 1f;
        GameIsPaused = false;
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
    void Pause ()
    {
        pauseMenuUI.SetActive(true);
        Time.timeScale = 0f;
        GameIsPaused = true;
    } 
    public void LoadMenu()
    {
        Time.timeScale=1f;
        SceneManager.LoadScene("Menu");
    }
    public void QuitGame() 
    {
        Debug.Log("Quiting game....");
        Application.Quit();

    }
}

    


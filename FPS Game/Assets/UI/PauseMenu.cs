using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PauseMenu : MonoBehaviour
{
    private bool paused = false;
    [SerializeField] GameObject pauseMenuUI;

    // Start is called before the first frame update
    void Start()
    {
        Cursor.lockState = CursorLockMode.Locked;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            //if the game is already paused, resume game
            if(paused)
            {
                Cursor.lockState = CursorLockMode.Locked;
                ResumeGame();
            }
            else //otherwise pause game
            {
                Cursor.lockState = CursorLockMode.None;
                pauseMenuUI.SetActive(true);
                Time.timeScale = 0f;
                paused = true;
                Cursor.visible = true;
            }
        }
    }

    //Resume Game
    public void ResumeGame()
    {
        pauseMenuUI.SetActive(false);
        Time.timeScale = 1.0f;
        paused = false;
        Cursor.visible = false;
    }

    //Quit Game
    public void QuitGame()
    {
        Debug.Log("Quits the game");
        Application.Quit();
    }

    public void MainMenu()
    {
        SceneManager.LoadScene("MainMenu");
    }
}

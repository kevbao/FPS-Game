using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ControlPanel : MonoBehaviour
{
    private bool paused = false;
    [SerializeField] GameObject panelMenuUI;
    public Transform planetMg;
    [SerializeField] GameObject planetMg_obj;

    // Start is called before the first frame update
    void Start()
    {
        Cursor.lockState = CursorLockMode.Locked;
        planetMg_obj.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.N))
        {
            //if the game is already paused, resume game
            if (paused)
            {
                Cursor.lockState = CursorLockMode.Locked;
                ResumeGame();
            }
            else //otherwise pause game
            {
                Cursor.lockState = CursorLockMode.None;
                panelMenuUI.SetActive(true);
                Time.timeScale = 0f;
                paused = true;
                Cursor.visible = true;
            }
        }
    }

    //Resume Game
    public void ResumeGame()
    {
        panelMenuUI.SetActive(false);
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

    //Go To Main Menu
    public void MainMenu()
    {
        SceneManager.LoadScene("MainMenu");
    }

    public void showWorlds()
    {
        planetMg_obj.SetActive(true);
        planetMg.Translate(0,1,0);
        planetMg.Rotate(0,0,0);
        ResumeGame();
    }
}

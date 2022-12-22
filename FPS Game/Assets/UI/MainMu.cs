using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMu : MonoBehaviour
{
    private bool paused = false;
    [SerializeField] GameObject mainMenuUI;

    // Start is called before the first frame update
    void Start()
    {
        Cursor.lockState = CursorLockMode.None;
        mainMenuUI.SetActive(true);
        Time.timeScale = 0f;
        paused = true;
        Cursor.visible = true;
    }

    // Update is called once per frame
    void Update()
    {

    }

    //Resume Game
    public void StartGame()
    {
        SceneManager.LoadScene("TutorialLevel-Perihelion");
        Cursor.lockState = CursorLockMode.Locked;
        mainMenuUI.SetActive(false);
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
}

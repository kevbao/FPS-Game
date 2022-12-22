using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class GameManager : MonoBehaviour
{
    bool gameHasEnded = false;
    public float restartDelay = 1f;
    //public GameObject ;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.N))
        {

            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex+1);

        }
        if (Input.GetKeyDown(KeyCode.R))
        {

            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);

        }
        if (Input.GetKeyDown(KeyCode.Escape))
        {

            Application.Quit();

        }
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "WinPoint" || Input.GetKeyDown(KeyCode.N))
        {
            //if (InventorySystem.Instance.Add(Item);
            //Application.LoadLevel();
            //LoadNextlevel();
            CompleteLevel();

        }


    }
    public void CompleteLevel()
    {
        Debug.Log("LEVEL WON!");
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }
    public void EndGame ()
    {
        if(gameHasEnded == false|| Input.GetKeyDown(KeyCode.R))
        {
            gameHasEnded = true;
            Debug.Log("GAME OVER");
            Invoke("Restart", restartDelay);
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);

        }
    }
    public void Restart()
    {
        if (gameHasEnded == false || Input.GetKeyDown(KeyCode.R))
        {
            gameHasEnded = true;
            Debug.Log("GAME OVER");
            Invoke("Restart", restartDelay);
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);

        }
    }
}

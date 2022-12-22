using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class WinPoints : MonoBehaviour
{
    public int nextlevel;
    GameManager gameManager;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnTriggerEnter(Collider other)
    {
        if(other.tag == "WinPoint"|| Input.GetKeyDown(KeyCode.N))
        {
            //if (InventorySystem.Instance.Add(Item);
            //Application.LoadLevel();
            //LoadNextlevel();
            gameManager.CompleteLevel();

        }

        
    }
    public void LoadNextlevel()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex+1);

    }
}

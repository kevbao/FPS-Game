using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class WorldPick : MonoBehaviour
{
    public Transform planetMg;
    public Transform player;
    public Transform planet1;
    public Transform planet2;
    public Transform planet3;

    private float playerPos;
    private float disP1;
    private float disP2;
    private float disP3;
    private int planet = 0;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.RightArrow))
        {
            planetMg.Rotate(0f, 90f, 0f);
        }
        if (Input.GetKeyDown(KeyCode.LeftArrow))
        {
            planetMg.Rotate(0f, -90f, 0f);
        }

        //finding the distances
        playerPos = player.position.x;
        disP1 = planet1.position.x - playerPos;
        disP2 = planet2.position.x - playerPos;
        disP3 = planet3.position.x - playerPos;
        
        //if the planets are higher the player
        if(planetMg.position.y > player.position.y) 
        {
            if (disP1 < disP2 && disP1 < disP3)
            {
                planet = 1;
            }
            else if (disP2 < disP1 && disP2 < disP3)
            {
                planet = 2;
            }
            else if (disP3 < disP1 && disP3 < disP1)
            {
                planet = 3;
            }
            else
            {
                Debug.Log("Not Moving");
                planet = 0;
            }
        }

        //if the user confirmed planet pick switch to planet scene
        if (Input.GetKeyDown(KeyCode.C))
        {
            switch (planet)
            {
                case 1:
                    Debug.Log("Moving to level 1");
                    SceneManager.LoadScene("Lvl_1");
                    break;
                case 2:
                    Debug.Log("Moving to level 2");
                    SceneManager.LoadScene("Lvl_2");
                    break;
                case 3:
                    Debug.Log("Moving to tutorial");
                    SceneManager.LoadScene("TutorialLevel-Perihelion");
                    break;
            }
        }
    }
}

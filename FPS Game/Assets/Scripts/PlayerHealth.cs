using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerHealth : MonoBehaviour
{
    public float Health = 100f;
    //public GameObject DeathUI;

    public void GameOver()
    {
        //UnityEngine.Debug.Log("uIsdead");
        //DeathUI.SetActive(true);
        Time.timeScale = 0f;
    }

}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player_health : MonoBehaviour
{
    //public int maxHealth = 100;
    //public int currentHealth;
    //public HealthBar_P healthbar_player;
    public float maxHealth = 100;
    public float currentHealth;
    [SerializeField] HealthBar healthbar_player;
    public static bool isGameOver;
    //animation
    private Animator animator;

    // Start is called before the first frame update
    void Start()
    {
        isGameOver = false;
        currentHealth = maxHealth;
        healthbar_player.SetHealth(currentHealth);

        //play animation
        animator = GetComponent<Animator>();

    }

    //// Update is called once per frame
    void Update()
    {
        ////Testing
        //if (Input.GetKeyDown(KeyCode.Space))
        //{
        //    TakeDamage(10);
        //}
        //can delete later

    }

    public void TakeDamage(int damage)
    {
        currentHealth -= damage;

        //change color and value about healthbar
        healthbar_player.SetHealth(currentHealth);

        //// if player have one life and dead, game over
        //if(currentHealth <= 0)
        //{
        //    // animation is dead
        //    animator.SetBool("dead", true);
        //    isGameOver = true; ///!!!!!! attention
        //    //display game over screen
        //}

    }
    public void Heal(int amount)
    {
        currentHealth += amount;

        if (currentHealth > maxHealth)
        {
            currentHealth = maxHealth;
        }
        //change color and value about healthbar
        healthbar_player.SetHealth(currentHealth);
    }


}

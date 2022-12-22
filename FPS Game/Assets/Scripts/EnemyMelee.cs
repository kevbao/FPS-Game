using UnityEngine;

public class EnemyMelee : MonoBehaviour
{
    public float range = 1.1f;
    public Transform attackPoint;
    public LayerMask playerLayer;
 
    bool playerCheck;
    public float damage = 20f;

    public float attackSpeed = 1f;
    float nextTimeToFire = 0f;

    // Update is called once per frame
    void Update()
    {
        playerCheck = Physics.CheckSphere(attackPoint.position, range, playerLayer);

        if (playerCheck == true && Time.time >= nextTimeToFire)
        {
            Attack();
            nextTimeToFire = Time.time + 1f / attackSpeed;
        }
    }

    void Attack()
    {
        FindObjectOfType<Player_health>().currentHealth -= damage;
        if(FindObjectOfType<Player_health>().currentHealth <= 0)
        {
            //FindObjectOfType<PlayerHealth>().GameOver();
        }

        UnityEngine.Debug.Log("Damage Taken");
    }
}

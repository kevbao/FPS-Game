using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

//create NavMesh and bake area for enemies to access
//make immovable objects navigation static
//add NavMeshAgent for enemy

//under the script in inspector, set the player as the player controller
//the enemy distance run variable can also be modified to whatever range you'd
//like for when they notice you and start to chase

public class EnemyChase : MonoBehaviour
{
    private NavMeshAgent Enemy;
    public GameObject Player;
    public float EnemyDistanceRun = 10.0f;

    public Animation anim;
    //Freezing Bullet
    public Rigidbody m_Rigidbody;
    private float freezeTime; // Seconds to freeze
    private bool Freezing; // Is freezing or not
    //anim["idle"].layer = -1;
    //anim["run"].layer = 1;
    // Start is called before the first frame update
    void Start()
    {
        Enemy = GetComponent<NavMeshAgent>();
        m_Rigidbody = gameObject.GetComponent<Rigidbody>();


        anim = GetComponent<Animation>();

    }

    // Update is called once per frame
    void Update()
    {
        float distance = Vector3.Distance(transform.position, Player.transform.position);

        //run towards player
        if(distance < EnemyDistanceRun && !Freezing)
        {
            Vector3 dirToPlayer = transform.position - Player.transform.position;
            Vector3 newPos = Player.transform.position;
            Enemy.SetDestination(newPos);
        }
        if (freezeTime > 0.0f)
        {
            freezeTime -= Time.deltaTime;
            Freezing = true;
            return;

        }
        else
        {
            UnFreeze();
        }


    }
    void OnCollisionEnter(Collision obj)
    {


        //if (obj.gameObject.tag == "FreezeBullet" && (obj.gameObject as "FreezeBullet").Freezeing)
        if (obj.gameObject.tag == "FreezeBullet" && !Freezing)
        {

            Freeze();
            //Freezing = false;
        }


    }
    void Freeze()
    {
        //StartCoroutine(CountDown());

        //Freeze all positions
        //object reference not set to an instance of an object
        Debug.Log("Freeze activated");
        //EnemyController[] enemies = FindObjectsOfType<EnemyController>();
        //Freeze all positions
        m_Rigidbody.constraints = RigidbodyConstraints.FreezePosition | RigidbodyConstraints.FreezeRotation;
        m_Rigidbody.centerOfMass = Vector3.zero;
        m_Rigidbody.velocity = Vector3.zero;
        m_Rigidbody.velocity = Vector3.zero;
        Enemy.GetComponent<NavMeshAgent>().enabled = false;

        //m_Rigidbody.Sleep();
        //Debug.Log("sleep");
        //enemy.GetComponent<EnemyController>().enabled = false;
        //anim.CrossFade("idle", PlayMode.StopAll);
        Debug.Log("Finish");
        Freezing = true;
        freezeTime = 5.0f;


    }
    void UnFreeze()
    {
        Freezing = false;
        freezeTime = 0.0f;
        //m_Rigidbody.WakeUp();
        //Debug.Log("wakeup");
        m_Rigidbody.constraints = RigidbodyConstraints.None;
        Enemy.GetComponent<NavMeshAgent>().enabled = enabled;


    }
}

using System.Collections;
using System.Collections.Generic;
using System.Security.Cryptography;
using System.Threading;
using UnityEngine;
using UnityEngine.AI;

public class RangedEnemy : MonoBehaviour
{
    [SerializeField] Transform target;
    [SerializeField] float EnemyRange = 20f;
    private float distanceBetweenTarget;
    private NavMeshAgent navMeshAgent;

    [SerializeField] private Transform[] projectileSpawnPoint;
    [SerializeField] private GameObject projectilePrefab;

    private float countdownBetweenfire = 0f;
    [SerializeField] private float FireRate = 2f;

    // Start is called before the first frame update
    void Start()
    {
        navMeshAgent = GetComponent<NavMeshAgent>();
    }

    // Update is called once per frame
    void Update()
    {
        distanceBetweenTarget = Vector3.Distance(target.position, transform.position);

        if (distanceBetweenTarget <= EnemyRange)
        {
            navMeshAgent.SetDestination(target.position);
        }

        if (distanceBetweenTarget <= navMeshAgent.stoppingDistance)
        {
            if (countdownBetweenfire <= 0f)
            {
                foreach (Transform SpawnPoints in projectileSpawnPoint)
                {
                    Instantiate(projectilePrefab, SpawnPoints.position, transform.rotation);
                }

                countdownBetweenfire = 1f / FireRate;
            }
            countdownBetweenfire -= Time.deltaTime;
        }
    }
}

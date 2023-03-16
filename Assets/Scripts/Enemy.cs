using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.AI;

public class Enemy : MonoBehaviour
{
    public float detectionDistance = 10f;
    public float attackDistance = 2f;

    private Transform player;
    private NavMeshAgent navMeshAgent;

    private float timeElapsed = 0f;

    void Start()
    {
        player = GameObject.FindGameObjectWithTag("Player").transform;

        navMeshAgent = GetComponent<NavMeshAgent>();
        navMeshAgent.speed = 5f; // Set the NavMeshAgent's speed
        navMeshAgent.stoppingDistance = attackDistance; // Set the stopping distance for attacking
    }

    void Update()
    {
        timeElapsed += Time.deltaTime;

        if (timeElapsed >= 10f)
        {
            float distanceToPlayer = Vector3.Distance(transform.position, player.position);

            if (distanceToPlayer <= detectionDistance)
            {
                navMeshAgent.SetDestination(player.position); // Set the NavMeshAgent's destination to the player's position

                if (distanceToPlayer <= attackDistance)
                {
                    Debug.Log("Enemy attacked player!");
                }
            }
        }
    }

    void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            GameManager.Instance.GameOver();
        }
    }
}

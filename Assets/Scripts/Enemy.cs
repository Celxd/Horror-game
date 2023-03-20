using UnityEngine;
using UnityEngine.AI;

public class Enemy : MonoBehaviour
{
    private Transform player;
    private NavMeshAgent navMeshAgent;

    private float attackDistance = 2f;
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

        // Create a raycast from the enemy to the player to check if there are any obstacles in the way
        RaycastHit hit;
        if (Physics.Raycast(transform.position, (player.position - transform.position).normalized, out hit))
        {
            // If the obstacle is the player, enable the NavMeshAgent and disable the obstacle
            if (hit.collider.CompareTag("Player"))
            {
                navMeshAgent.isStopped = false;
                navMeshAgent.SetDestination(player.position);
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

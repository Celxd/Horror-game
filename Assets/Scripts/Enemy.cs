using Unity.VisualScripting;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    public float speed = 5f;
    public float detectionDistance = 10f;
    public float attackDistance = 2f;

    private Transform player;

    // Add these lines to define the enemy's collider
    private Rigidbody rb;
    private CapsuleCollider coll;

    void Start()
    {
        player = GameObject.FindGameObjectWithTag("Player").transform;

        // Add these lines to get and configure the enemy's collider
        rb = GetComponent<Rigidbody>();
        rb.collisionDetectionMode = CollisionDetectionMode.ContinuousDynamic;
        coll = gameObject.AddComponent<CapsuleCollider>();
        coll.radius = 0.5f; // Change the radius according to the size of the enemy
        coll.height = 2f; // Change the height according to the size of the enemy
    }

    void Update()
    {
        float distanceToPlayer = Vector3.Distance(transform.position, player.position);

        if (distanceToPlayer <= detectionDistance)
        {
            // Chase the player
            transform.LookAt(player);
            transform.Translate(Vector3.forward * speed * Time.deltaTime);

            if (distanceToPlayer <= attackDistance)
            {
                // Attack the player
                Debug.Log("Enemy attacked player!");
            }
        }
    }

    // Add this method to detect collisions with the player
    void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            // Do something when enemy collides with the player
            Debug.Log("Kill");
        }
    }
}
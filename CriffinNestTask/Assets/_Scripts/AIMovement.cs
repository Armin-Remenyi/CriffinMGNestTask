using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class AIMovement : MonoBehaviour
{
    public float health = 10f;
    public NavMeshAgent agent;

    [SerializeField] private Transform movePositionTransform;

    // Start is called before the first frame update
    void Start()
    {
        agent = GetComponent<NavMeshAgent>();
    }

    void Awake()
    {
       
    }

    // Update is called once per frame
    void Update()
    {
        agent.destination = movePositionTransform.position; 
    }
    public void TakeDamage(float amount)
    {
        health -= amount;
        if (health <= 0f)
        {
            Score.scoreValue += 2;
            Die();
        }
    }
    void Die()
    {
        Destroy(gameObject);
    }
    private void OnTriggerEnter(Collider collision)
    {
        if (collision.gameObject.tag == "Nest")
        {
            NestHealth.maxHealth -= 1;
            Destroy(gameObject);

        }
    }
}

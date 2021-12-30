using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AIMovement : MonoBehaviour
{
    public Transform Nest;
    public int MoveSpeed = 3;
    public int MaxDistance = 10;
    public int MinDistance = 5;
    public float health = 10f;


    GameObject target;


    // Start is called before the first frame update
    void Start()
    {
        target = GameObject.Find("Nest");
    }

    // Update is called once per frame
    void Update()
    {
        transform.LookAt(Nest);

        if (Vector3.Distance(transform.position, Nest.position) >= MinDistance)
        {

            transform.position += transform.forward * MoveSpeed * Time.deltaTime;

            if (Vector3.Distance(transform.position, Nest.position) <= MaxDistance)
            {

            }
        }
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

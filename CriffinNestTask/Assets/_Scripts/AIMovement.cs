using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AIMovement : MonoBehaviour
{
    public Transform Nest;
    public int MoveSpeed = 4;
    public int MaxDistance = 10;
    public int MinDistance = 5;
    public float health = 50f;


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


    void Die()
    {
        Destroy(gameObject);
    }


    private void OnTriggerEnter(Collider collision)
    {
        if (collision.gameObject.tag == "Nest")
        {
            Destroy(gameObject);

        }
    }
}

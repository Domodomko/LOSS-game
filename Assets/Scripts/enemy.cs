using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemy : MonoBehaviour
{
    public float speed;
    public float stoppingDistance;
    public float speedup;
    public float speeduprate;
    public float next;

    private Transform target;

    // Start is called before the first frame update
    void Start()
    {
        target = GameObject.FindGameObjectWithTag("KEK").GetComponent<Transform>();
    }

    // Update is called once per frame
    void Update()
    {

        if (Vector2.Distance(transform.position, target.position) > stoppingDistance)
        {
            if (Time.time >next)
            {
                if (speed < 1.9f)
                {
                    next = Time.time + speeduprate;
                    speed = speed + speedup;
                }
            }
            transform.position = Vector2.MoveTowards(transform.position, target.position, speed * Time.deltaTime);
        }
    }
}

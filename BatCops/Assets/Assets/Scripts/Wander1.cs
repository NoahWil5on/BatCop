using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class Wander1 : Wander {
    
    public GameObject door;
    public GameObject fleeingTarget;

    public int multiplyBy = 5;
    public float fleeRadius = 30.0f; // The radius of how close it has to be to fleeingTarget before it runs
    
    private Vector3 newPos;

    void Start()
    {
        nav = GetComponent<NavMeshAgent>();
        timer = wanderT;
    }

    // Update is called once per frame
    void Update()
    {
        float dist = Vector3.Distance(transform.position, fleeingTarget.transform.position);
        if (dist > fleeRadius)
        {
            Seek();
        }
        else
        {
            Flee();
        }
    }
    
    public void Seek()
    {
        nav.SetDestination(door.transform.position);
        //Debug.DrawLine(transform.position, newPos, Color.red);
        timer = 0;
    }

    public void Flee()
    {
        Vector3 runTo = multiplyBy * (transform.position - fleeingTarget.transform.position);
        nav.SetDestination(runTo);
    }

}

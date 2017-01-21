using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

enum ratStates
{
    initialWander,
    flee,
    timedWander,
    seek
}

public class Wander1 : Wander {
    
    public GameObject door;
    public GameObject fleeingTarget;

    public int multiplyBy = 5;
    public float fleeRadius = 30.0f; // The radius of how close it has to be to fleeingTarget before it runs
    
    private Vector3 newPos;
    private bool isFleeing;  // Checks to see if this GameObject should be fleeing now or not
    private bool dead;
    private ratStates fsm;


    public bool IsFleeing
    {
        get { return isFleeing; }
        set { isFleeing = value; }
    }

    public bool Dead
    {
        get { return dead; }
        set { dead = value; }
    }

    void Start()
    {
        nav = GetComponent<NavMeshAgent>();
        timer = wanderT;
        isFleeing = false;
        dead = false;

        fsm = ratStates.initialWander;
    }

    // Update is called once per frame
    void Update()
    {
        if(fsm == ratStates.initialWander)
        {

        }
        if (isFleeing)
        {
            Flee();
        }
        else
        {
            Seek();
        }

        if (dead)
        {

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

        // Checks to see if this GameObject should still be fleeing
        float dist = Vector3.Distance(transform.position, fleeingTarget.transform.position);
        if (dist > fleeRadius)
        {
            isFleeing = false;
        }
    }
}

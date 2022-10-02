using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IdleState : State
{
    [SerializeField]
    private GameObject[] points;
    [SerializeField]
    private UnityEngine.AI.NavMeshAgent agent;
    [SerializeField]
    float aray = 7;

    public ChaseState chaseState;
    public bool canSeeThePlayer;

    private int currPoint;

    private void Start()
    {
        agent = GetComponent<UnityEngine.AI.NavMeshAgent>();
        agent.autoBraking = false;
        currPoint = 0;
        agent.destination = points[currPoint].transform.position;
    }

    private void Update()
    {
        if (Vector3.Distance(this.transform.position, points[currPoint].transform.position) <= aray)
        {
            iterate();
        }
    }
    void iterate()
    {
        if (currPoint < points.Length - 1)
        {
            currPoint++;
        }
        else
        {
            currPoint = 0;
        }
        agent.destination = points[currPoint].transform.position;
    }

    public override State RunCurrentState()
    {
        if (canSeeThePlayer)
        {
            return chaseState;
        }
        else
        {
            return this;
        }
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class AgentController : MonoBehaviour
{
    private NavMeshAgent agent;
    private Chocked chocked;
    public Transform target;
    // Start is called before the first frame update
    void Start()
    {
        chocked = GetComponent<Chocked>();
        agent = GetComponent<NavMeshAgent>();
    }

    // Update is called once per frame
    void Update()
    {
        if(!chocked.isChocked)
            agent.destination = target.position;
    }
}

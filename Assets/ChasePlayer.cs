using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class ChasePlayer : MonoBehaviour
{
    public Transform player;            
    private NavMeshAgent agent;
    void Start()
    {
      agent = GetComponent<NavMeshAgent>();
    }

    void Update()
    {
      if (Vector3.Distance(player.position, transform.position) < 10)
        {
            agent.SetDestination(player.position);
        
        }   
      }
}


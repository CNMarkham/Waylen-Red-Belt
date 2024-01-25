using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class NavMeshMovement : MonoBehaviour
{
     NavMeshAgent posNav;
    // Start is called before the first frame update
    void Start()
    {
        posNav.destination = goal.transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        agent.destination = goal.transform.position;
    }
}

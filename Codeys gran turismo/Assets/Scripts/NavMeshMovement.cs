using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class NavMeshMovement : MonoBehaviour
{
    public NavMeshAgent posNav;
    public GameObject goal;
    

    // Start is called before the first frame update
    void Start()
    {
        goal = GameObject.FindGameObjectWithTag("po");
        posNav.destination = goal.transform.position;
         
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "po")
        {
            Destroy(collision.gameObject);
        }
    }

}

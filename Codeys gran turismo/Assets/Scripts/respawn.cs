using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;



public class respawn : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnCollisionEnter(Collision collision)
    {
        Debug.Log("Hi!REMEMBER TO CHECK YOUR KIDS IN!!!");
        if (collision.gameObject.tag == ("gucci"))
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }
}

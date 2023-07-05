 using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Throwable : MonoBehaviour
{
    public GameObject objectThrown;
    public Vector3 offset;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        offset = transform.localScale.x * new Vector3(1, 0, 0);
        Vector3 throwablePosition = transform.position + offset;
        if (Input.GetButtonDown("Fire1"))
        {
            Instantiate(objectThrown, throwablePosition, transform.rotation);
        }
        //offset = transform.localScale.x * new Vector3(1, 0, 0);
        //Vector3 throwablePosition = transform.position + offset;
    }
}

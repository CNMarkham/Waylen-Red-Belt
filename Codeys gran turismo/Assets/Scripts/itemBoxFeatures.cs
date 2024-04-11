using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class itemBoxFeatures : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Rotate(new Vector3(69,69,69));
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Codey")
        {
            gameObject.SetActive(false);
            Invoke("itemBoxRespawn", 2);
        }
    }

    private void itemBoxRespawn()
    {
        gameObject.SetActive(true);
    }
}

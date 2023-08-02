 using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Throwable : MonoBehaviour
{
    public GameObject objectThrown;
    public Vector3 offset;
    public int throwableCounter;
    public Text collectableCounter;
    // Start is called before the first frame update
    void Start()
    {
        throwableCounter = 0; 
    }

    // Update is called once per frame
    void Update()
    {
        offset = transform.localScale.x * new Vector3(1, 0, 0);
        Vector3 throwablePosition = transform.position + offset;
        if (Input.GetButtonDown("Fire1"))
        {
             if (throwableCounter > 0)
            {
                Instantiate(objectThrown, throwablePosition, transform.rotation);
                throwableCounter -= 1;
                collectableCounter.text = throwableCounter.ToString();
            }
             //Instantiate(objectThrown, throwablePosition, transform.rotation);
        }
        //offset = transform.localScale.x * new Vector3(1, 0, 0);
        //Vector3 throwablePosition = transform.position + offset;
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
      if (collision.gameObject.CompareTag("Collectable"))
      {
            throwableCounter += 1;
            Destroy(collision.gameObject);
            collectableCounter.text = throwableCounter.ToString(); 
        }

    }
}

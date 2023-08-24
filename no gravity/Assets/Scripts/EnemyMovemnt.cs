using UnityEngine;

public class EnemyMovemnt : MonoBehaviour
{
    public int x1;
    public int x2;
    public float yForce;
    public float xForce;
    public float xDirection;

    private Rigidbody2D enemyRigidBody;
    public GameObject pOrtAl;
    // Start is called before the first frame update
    void Start()
    {
        enemyRigidBody = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.tag == "Ground")
        {
            Vector2 jumpForce = new Vector2(xForce * xDirection, yForce);
            enemyRigidBody.AddForce(jumpForce);
        }

        if (pOrtAl.GetComponent<Teleport>() && collision.gameObject.tag == "platypus")
        {
           
            Destroy(gameObject);
            pOrtAl.GetComponent<Teleport>().enemyCount -= 1;
        }

        if (pOrtAl.GetComponent<Teleport2>() && collision.gameObject.tag == "platypus")
        {
            pOrtAl.GetComponent<Teleport2>().enemyCount -= 1;
            Destroy(gameObject);
        }

    }

    private void FixedUpdate()
    {
        if (transform.position.x <= x1)
        { 
            xDirection = 1;
            enemyRigidBody.AddForce(Vector2.right * xForce);
        }
        if (transform.position.x >= x2)
        {
        xDirection = -1;
            enemyRigidBody.AddForce(Vector2.left * xForce);     
        }
    }
}

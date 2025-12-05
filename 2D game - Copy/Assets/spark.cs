using UnityEngine;

public class Spark : MonoBehaviour
{
    public float speed = 30f;
    public Vector2 direction = Vector2.right;
    public GoalTarget goalTargetScript; 

    private Rigidbody2D rb;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        rb.linearVelocity = direction.normalized * speed; 
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player")) 
        {

            goalTargetScript.MinPoint(); 
            //Destroy(gameObject);         
        }
    }
}

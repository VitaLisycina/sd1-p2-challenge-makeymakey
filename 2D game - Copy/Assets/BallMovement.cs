using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UIElements;
using static UnityEngine.UIElements.UxmlAttributeDescription;

public class BallMovement : MonoBehaviour
{
    private float ballSpeed = 5;
    private int hitCounter = 0;    
    private float speedIncrease = 1f; 
    private float maxSpeed = 30f;


    private float direction;
    private Rigidbody2D rb;


    void Start()
    {
        rb = GetComponent<Rigidbody2D>();

        rb.linearVelocity = ballSpeed * new Vector2(1f, 0f);
        float randomY = Random.Range(-1f, 1f);
        Vector2 startDir = new Vector2(1f, randomY);

        startDir = startDir.normalized;
        rb.linearVelocity = ballSpeed * startDir;
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        
        if (collision.gameObject.CompareTag("Player"))
        {
            hitCounter++;

          
            if (hitCounter >= 2)
            {
                
                rb.linearVelocity = rb.linearVelocity.normalized * Mathf.Min(rb.linearVelocity.magnitude + speedIncrease, maxSpeed);

                          
            }
        }

    }

    public void ResetBall(int spawnDirection)
    {
        rb.linearVelocity *= spawnDirection;
        transform.position = new Vector3(spawnDirection, Random.Range(-1f, 1f), 0);
        rb.linearVelocity = ballSpeed * new Vector2(1f, 0f);
        float randomY = Random.Range(-1f, 1f);
        Vector2 startDir = new Vector2(1f, randomY);

        startDir = startDir.normalized;
        rb.linearVelocity = ballSpeed * startDir;

    }

    
}


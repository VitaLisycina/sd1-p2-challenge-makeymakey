using UnityEngine;
using System.Collections;

public class TargetRandomSpawn : MonoBehaviour
{
    public float minX = -7f;
    public float maxX = -7f;
    public float minY = -3.8f;
    public float maxY = 3.8f;

    public float respawnDelay = 1f;

    private SpriteRenderer sr;
    private Collider2D col;
    public GoalTarget goalTarget;

    void Start()
    {
        sr = GetComponent<SpriteRenderer>();
        col = GetComponent<Collider2D>();
        Respawn();
    }

    public void Respawn()
    {
        float x = Random.Range(minX, maxX);
        float y = Random.Range(minY, maxY);
        transform.position = new Vector3(x, y, 0f);
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        
        if (other.GetComponent<BallMovement>())
        {
            goalTarget.AddPoint();
            StartCoroutine(RespawnRoutine());
        }
    }


    IEnumerator RespawnRoutine()
    {
        SetVisible(false);
        yield return new WaitForSeconds(respawnDelay);
        Respawn();
        SetVisible(true);
    }

    void SetVisible(bool visible)
    {
        if (sr) sr.enabled = visible;
        if (col) col.enabled = visible;
    }

   

}

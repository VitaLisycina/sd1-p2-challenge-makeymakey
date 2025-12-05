using UnityEngine;

public class RightWall : MonoBehaviour
{
    public GameManager gameManager;
    public BallMovement ballScript;  
    public GameObject ball;
    
    private void OnCollisionEnter2D(Collision2D collision)
    {
        
       
            gameManager.GamePlayEnd(); 
        
        
    }
}

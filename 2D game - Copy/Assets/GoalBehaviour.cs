using TMPro;
using UnityEngine;

public class GoalBehaviour : MonoBehaviour
{

    public int score = 0;
    public TMP_Text scoreText;

    public BallMovement ballScript;
    public int goalSide;
    public GameObject ball;
    public GameManager  GameManegerScript;

    private void OnCollisionEnter2D(Collision2D collision)
    {

        score++;
        scoreText.text = score.ToString();

        ballScript.ResetBall(goalSide);

        if (score >= 10)
        {
            GameManegerScript.GamePlayEnd();
        }
        
            

           
        

    }
}

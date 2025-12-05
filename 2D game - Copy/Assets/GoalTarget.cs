using TMPro;
using UnityEditor;
using UnityEngine;

public class GoalTarget : MonoBehaviour
{
    public int score = 0;
    public TMP_Text scoreT;

    public GameManager GameManegerScript;
    public BallMovement ballScript;
    
    

    public void AddPoint()
    {
        score++;
        scoreT.text = score.ToString();
    }

    public void MinPoint()
    {
        score = 0; ;
        scoreT.text = score.ToString();
        Destroy(gameObject);
    }

}




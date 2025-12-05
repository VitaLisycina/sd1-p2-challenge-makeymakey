using TMPro;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{

    public BallMovement ballScript;
    public GameObject gameOverScreen;
    public TMP_Text leftScoreText;
    public TMP_Text rightScoreText;
    public GoalBehaviour leftGoalBehaviour;
    public GoalBehaviour rightGoalBehaviour;
    public GoalTarget goalTarget;
    public RightWall rightWall;
    public TMP_Text ScoreT;
    public Rigidbody2D ball; 

   


void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            Application.Quit();
        }

        if (Input.GetKeyDown(KeyCode.G))
        {
            SceneManager.LoadScene("ping pong scene", LoadSceneMode.Single);
        }

        if (Input.GetKeyDown(KeyCode.A))
        {
            SceneManager.LoadScene("target scene", LoadSceneMode.Single);
        }

        if (Input.GetKeyDown(KeyCode.S))
        {
            SceneManager.LoadScene("menu");
          }
    }

    public void GamePlayEnd()
    {
        gameOverScreen.SetActive(true);
        ball.linearVelocity = Vector2.zero;
        ball.transform.position = new Vector3(0, 0, 0);




    }
    public void ResetGame()
    {
        gameOverScreen.SetActive(false);
        leftGoalBehaviour.score = 0;
        rightGoalBehaviour.score = 0;
        leftGoalBehaviour.scoreText.text = "0";
        rightGoalBehaviour.scoreText.text = "0";
        ballScript.ResetBall(-1);

        Time.timeScale = 1f;
    }



}

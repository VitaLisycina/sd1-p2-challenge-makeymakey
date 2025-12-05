using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{

    public GoalTarget goalTargetScript;
    public int playerNumber = 1;
    private float pedalSpeed = 8f;

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Spark"))
        {
            goalTargetScript.MinPoint();
            Destroy(other.gameObject);

            Debug.Log("Hit by Spark");
        }
    }


    void Start()
    {
        Debug.Log("Start");
    }

    void Update()
    {
        float verticalInput = 0f;


        if (playerNumber == 1)
        {
            if (Input.GetKey(KeyCode.LeftArrow) && transform.position.y <= 3.97f)
            {
                verticalInput = 1f;
            }
            else if (Input.GetKey(KeyCode.RightArrow) && transform.position.y >= -3.97f)
            {
                verticalInput = -1f;
            }
        }

        else if (playerNumber == 2)
        {
            if (Input.GetKey(KeyCode.UpArrow) && transform.position.y <= 3.97f)
            {
                verticalInput = 1f;
            }
            else if (Input.GetKey(KeyCode.DownArrow) && transform.position.y >= -3.97f)
            {
                verticalInput = -1f;
            }
        }


        transform.position += new Vector3(0f, verticalInput * pedalSpeed * Time.deltaTime, 0f);

        
    }
    

}

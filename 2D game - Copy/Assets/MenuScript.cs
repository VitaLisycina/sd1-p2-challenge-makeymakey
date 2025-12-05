using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuScript : MonoBehaviour
{
    

    public void StartPongGame()
    {

        SceneManager.LoadScene("ping pong scene", LoadSceneMode.Single);
        
    }

    public void StartTargetGame()
    {
        SceneManager.LoadScene("target scene", LoadSceneMode.Single);
    }

    public void StartMenu()
    {
        SceneManager.LoadScene("menu", LoadSceneMode.Single);
    }

}

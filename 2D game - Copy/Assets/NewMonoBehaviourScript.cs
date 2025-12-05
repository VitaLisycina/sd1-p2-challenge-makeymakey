using UnityEngine;

public class BackgroundChg : MonoBehaviour
{
    public SpriteRenderer backgroundRenderer;
    public Sprite[] backgrounds; 

    public void ChangeBackground()
    {
        int randomIndex = Random.Range(0, backgrounds.Length);
        backgroundRenderer.sprite = backgrounds[randomIndex];
    }
}


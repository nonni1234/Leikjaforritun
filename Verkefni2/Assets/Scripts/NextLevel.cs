using UnityEngine;

public class NextLevel : MonoBehaviour
{
    public GameManager gameManager;

    public void nextLevel() // notað af endscreen animationinu til að loada næsta level
    {
        gameManager.LoadNextLevel();
    }
}

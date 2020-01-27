using UnityEngine;

public class Endir : MonoBehaviour
{
    public GameManager gameManager;

    void OnTriggerEnter() // Keyrist þegar level er klárað
    {
        gameManager.CompleteLevel(); // Klárar levelið og fer á næsta
    }
}

using UnityEngine;

public class Spin : MonoBehaviour
{
    public GameManager gameManager;
    private void OnTriggerEnter()
    {
        Destroy(gameObject); // Drepur þetta game object
        gameManager.IncrementScore();

    }

    void FixedUpdate()
    {
        transform.Rotate(0, 2, 0); // Snýr coininum
    }
}

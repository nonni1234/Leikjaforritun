using UnityEngine;

public class GroundCollision : MonoBehaviour
{
    public PlayerMovement player;

    public void OnCollisionEnter() {
        player.Grounded();
    }
}

using UnityEngine;

public class PlayerCollision : MonoBehaviour
{
    public Movement movement;

    void OnCollisionEnter (Collision collisionInfo) {
        if(collisionInfo.collider.tag == "Obstacle") { // Keyrist ef Player collidar við Object
            movement.enabled = false;
            FindObjectOfType<GameManager>().EndGame(); // Byrjar levelið uppá nýtt
        }
    }
}

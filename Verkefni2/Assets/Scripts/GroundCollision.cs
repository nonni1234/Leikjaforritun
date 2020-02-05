using System.Collections;
using UnityEngine;

public class GroundCollision : MonoBehaviour
{
    public GameObject player;

    void OnCollisionEnter() {
        player.Grounded();
    }
}

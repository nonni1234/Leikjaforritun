using System.Collections;
using UnityEngine;

public class CameraMovement : MonoBehaviour {
    public Transform pl;
    public Vector3 offset;

    void FixedUpdate() {
        transform.position = pl.position + offset; // lætur myndavélina elta Playerinn
    }

}

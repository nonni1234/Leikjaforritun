using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }
    
    void Update() {
        if (Input.GetKey("space")) {
            rb.AddForce(0, 1000 * Time.deltaTime,0,ForceMode.JumpForce);
        }
    
    }
}

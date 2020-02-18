using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    Transform player;
    Rigidbody rb;
    GameObject pl;
    public GameManager gameManager;
    public Transform cam;
    bool grounded;
    public float Force;
    public float JumpForce;

    public float speedH = 2.0f;
    public float speedV = 2.0f;

    private float yaw = 0.0f;

    public void Grounded() { // Runnar þegar player collidar við ground
        grounded = true;
        Debug.Log("Grounded");
    }

    void Start()
    {
        Cursor.visible = false;
        rb = GetComponent<Rigidbody>();
        player = GetComponent<Transform>();
    }
  
    void FixedUpdate() {

        // Hreyfingin
        yaw += speedH * Input.GetAxis("Mouse X");

        transform.eulerAngles = new Vector3(0.0f, yaw, 0.0f);
        if (Input.GetKey("space") && grounded == true) { // Að hoppa
            Debug.Log("Jumped");
            grounded = false;
            rb.AddForce(0, JumpForce* Time.deltaTime,0,ForceMode.Impulse);
        }
        // wasd movement
        
        if (Input.GetKey("w"))
        {
            rb.AddRelativeForce(0,0, Force * Time.deltaTime, ForceMode.VelocityChange);
        }
        
        if (Input.GetKey("s"))
        {
            rb.AddRelativeForce(0, 0, -Force * Time.deltaTime, ForceMode.VelocityChange);
        }
        if (Input.GetKey("a"))
        {
            rb.AddRelativeForce(-Force * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
        }
        if (Input.GetKey("d"))
        {
            rb.AddRelativeForce(Force * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
        }
        if (transform.position.y < 0)
        {
            gameManager.ResetLevel();
        }
        

    }
}

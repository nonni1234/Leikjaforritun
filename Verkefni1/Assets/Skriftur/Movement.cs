using UnityEngine;

public class Movement : MonoBehaviour
{

    public Rigidbody rb;
    // Start is called before the first frame update
    void Start() {
        Debug.Log("Hello");
    }

    // Update is called once per frame
    void FixedUpdate() {
        if (Input.GetKeyDown ("up")) {
        rb.AddForce(0, 0,500*Time.deltaTime*60);
        }
        if (Input.GetKeyDown ("space")) {
        rb.AddForce(0, 500*Time.deltaTime*60 , 0);
        }
        if (Input.GetKeyDown ("down")) {
        rb.AddForce(0, 0, -500*Time.deltaTime*60);
        }
        if (Input.GetKeyDown ("left")) {
        rb.AddForce(-500*Time.deltaTime*60,0,0);
        }
        if (Input.GetKeyDown ("right")) {
        rb.AddForce(500*Time.deltaTime*60,0,0);
        }
    }
}

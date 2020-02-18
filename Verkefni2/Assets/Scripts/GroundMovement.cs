using UnityEngine;

public class GroundMovement : MonoBehaviour
{
    private float xpos;
    public float speed = 2;
    Vector3 startpos;
    private void Start()
    {
    xpos = transform.position.x; // geymir position á x axis
    startpos = transform.position; // Geymir byrjunarstaðsetninguna
}
    private void FixedUpdate()
    { // Hreyfir groundið fram of til baka
        if (xpos >= startpos.x+5f || xpos <= startpos.x-5f) 
        {
            speed = -speed; // Invertar speed
        }
        transform.position = new Vector3(xpos+=speed*Time.deltaTime,transform.position.y,transform.position.z);
    }
    

}

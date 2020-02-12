using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spin : MonoBehaviour
{
    public Transform coin;
    void FixedUpdate()
    {
        transform.Rotate(0, 2, 0);
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveTowardCollider : MonoBehaviour
{
    public Rigidbody rb;
    public float speed = -100;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        rb.AddForce(0f, 0f, speed);
    }
}

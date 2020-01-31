using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterMove : MonoBehaviour
{

    public float speed = 1;
    Rigidbody rb;

    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    void FixedUpdate()
    {
        float vertical = Input.GetAxis ("Vertical");
        float horizontal = Input.GetAxis ("Horizontal");
        float height = transform.position.y;
        
        Vector3 newPos = new Vector3(horizontal * speed + transform.position.x, height, vertical * speed + transform.position.z); 
        rb.MovePosition(newPos);
    }
}

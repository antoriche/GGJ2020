using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterMove : MonoBehaviour
{

    public float speed = 1;

    void Start()
    {
        
    }

    void FixedUpdate()
    {
        float vertical = Input.GetAxis ("Vertical");
        float horizontal = Input.GetAxis ("Horizontal");
        float height = transform.position.y;
        transform.Translate(horizontal * speed,0,vertical * speed);
        transform.position =  new Vector3(transform.position.x, height, transform.position.z); 
    }
}

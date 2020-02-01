using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterMove : MonoBehaviour
{

    public float speed = 1;
    Rigidbody rb;
    public GameObject player;

    void Start()
    {
        rb = player.GetComponent<Rigidbody>();
    }

    void FixedUpdate()
    {
        float vertical = Input.GetAxis("Vertical");
        float horizontal = Input.GetAxis("Horizontal");
        float height = player.transform.position.y;

        Vector3 direction = new Vector3(horizontal * speed, 0, vertical * speed);
        //Vector3 newPosition = rb.position + transform.TransformDirection(direction);
        player.transform.Translate(direction * Time.deltaTime, transform);
        player.transform.position = new Vector3(player.transform.position.x, height, player.transform.position.z);

        //rb.MovePosition(player.transform.position + direction);
        //transform.position = newPos;
    }
}

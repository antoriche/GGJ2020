using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Key : MonoBehaviour
{
    bool activated = false;
    // Start is called before the first frame update
    void OnCollisionEnter(Collision c)
    {
        Debug.Log("key");
    }

    // Update is called once per frame
    void Update()
    {

    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorScript : MonoBehaviour
{
    public bool canOpen = false;
    public Key key;

    private void Update()
    {
        canOpen = key.activated;
    }

    private void OnTriggerEnter(Collider other)
    {
        if(canOpen)
        {
            GetComponent<Animator>().SetBool("IsOpen", true);
        }
    }
}

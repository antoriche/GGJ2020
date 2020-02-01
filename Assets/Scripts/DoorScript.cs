using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorScript : MonoBehaviour
{
    public bool canOpen = false;
    public Key key;

    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player" && key.activated)
        {
            GetComponent<Animator>().SetBool("IsOpen", true);
        }
    }
}

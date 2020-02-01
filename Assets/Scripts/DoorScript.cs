using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorScript : MonoBehaviour
{
    public bool canOpen = false;

    private void OnTriggerEnter(Collider other)
    {
        Debug.Log("Rentre en collision avec la porte");
        if (canOpen)
        {
            GetComponent<Animator>().SetTrigger("PorteTrigger");
        }
    }
}

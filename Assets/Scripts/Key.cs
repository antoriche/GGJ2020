using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Key : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        GameObject.Find("RotateDoor").GetComponent<DoorScript>().canOpen = true;
        gameObject.SetActive(false);
    }
}

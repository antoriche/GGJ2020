using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Key : MonoBehaviour
{
    public bool activated = false;
    public KeyCode key = KeyCode.Mouse0;

    void OnTriggerStay(Collider c)
    {
        if (Input.GetKey(key))
        {
            activated = true;
            gameObject.SetActive(false);
        }
    }
}

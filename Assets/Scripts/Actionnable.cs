using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Actionnable : MonoBehaviour
{

    public bool consomable = false;
    public KeyCode key = KeyCode.Mouse0;

    void OnTriggerStay(Collider c)
    {
        if (Input.GetKey(key))
        {
            this.OnAction();
            if (consomable) gameObject.SetActive(false);
        }
    }

    public abstract void OnAction();
}

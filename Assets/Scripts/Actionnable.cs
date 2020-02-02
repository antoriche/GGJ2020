using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Actionnable : MonoBehaviour
{

    public bool consomable = false;
    public KeyCode key = KeyCode.Mouse0;

    private Color color;

    void OnTriggerEnter(Collider c)
    {
        color = GetComponentInChildren<Renderer>().material.color;
        GetComponentInChildren<Renderer>().material.color = Color.yellow;
    }
    void OnTriggerExit(Collider c)
    {
        GetComponentInChildren<Renderer>().material.color = color;
    }

    void OnTriggerStay(Collider c)
    {
        if (Input.GetKeyDown(key))
        {
            this.OnAction();
            if (consomable) gameObject.SetActive(false);
        }
    }

    public abstract void OnAction();
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Key : MonoBehaviour
{
    public bool activated = false;

    // Start is called before the first frame update
    void OnTriggerEnter(Collider c)
    {
        activated = true;
        gameObject.SetActive(false);
    }
}

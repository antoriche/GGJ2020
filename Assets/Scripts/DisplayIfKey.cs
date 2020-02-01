using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DisplayIfKey : MonoBehaviour
{

    public Key key;
    public GameObject target;

    // Update is called once per frame
    void Update()
    {
        target.SetActive(key.activated);
    }
}

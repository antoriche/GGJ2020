using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DisplayIfKey : MonoBehaviour
{

    public Key key;
    public bool invert;
    public GameObject target;

    // Update is called once per frame
    void Update()
    {
        target.SetActive(invert ? !key.activated : key.activated);
    }
}

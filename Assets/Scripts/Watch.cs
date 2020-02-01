using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Watch : MonoBehaviour
{
    public Transform pointer;

    // Update is called once per frame
    void Update()
    {
        float time = Timer.Instance.timeLeft;
        pointer.localRotation = Quaternion.Euler(0, 0, time / 60 * 360);
    }
}

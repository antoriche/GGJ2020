using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Watch : MonoBehaviour
{
    public Transform pointer;
    public float timeByTour = 60;

    // Update is called once per frame
    void Update()
    {
        float time = Timer.Instance.timeLeft;
        pointer.localRotation = Quaternion.Euler(0, 0, time / timeByTour * 360);
    }
}

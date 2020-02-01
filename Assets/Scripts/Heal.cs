using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Heal : MonoBehaviour
{
    public float healTimeValue = 10f;

    void OnTriggerEnter(Collider c)
    {
        Timer.Instance.timeLeft += healTimeValue;
        gameObject.SetActive(false);
    }
}

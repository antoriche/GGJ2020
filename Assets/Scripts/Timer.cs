using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Timer : Singleton<Timer>
{
    public float timeLeft = 20f;
    public float speedFactorOnPast = 2f;

    void Update()
    {
        timeLeft -= Time.deltaTime * (DimensionManager.Instance.isInThePast ? speedFactorOnPast : 1);
        if (timeLeft < 0)
        {
            Player.Instance.Die();
        }
    }
}

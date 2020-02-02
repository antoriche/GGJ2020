using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Timer : Singleton<Timer>
{
    public float timeLeft = 20f;
    public float max = 60;
    public float speedFactorOnPast = 2f;

    public void AddTimeLeft(float time)
    {
        timeLeft = Mathf.Min(timeLeft + time, max);
    }

    void Update()
    {
        timeLeft -= Time.deltaTime * (DimensionManager.Instance.isInThePast ? speedFactorOnPast : 1);

        if (timeLeft < 0)
        {
            Player.Instance.Die();
        }
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Heal : Actionnable
{
    public float healTimeValue = 10f;

    public override void OnAction()
    {
        Timer.Instance.timeLeft += healTimeValue;
    }
}

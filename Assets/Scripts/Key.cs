using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Key : Actionnable
{
    public bool activated = false;

    public override void OnAction()
    {
        activated = true;
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GasMask : Actionnable
{
    public List<KillerTrap> gas;
    public override void OnAction()
    {
        foreach (KillerTrap g in gas)
        {
            Destroy(g);
        }
    }
}

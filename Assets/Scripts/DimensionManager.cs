using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DimensionManager : Singleton<DimensionManager>
{
    public float switchCost = 2f;
    public KeyCode switchKey = KeyCode.A;

    private List<DimensionObject> objects = new List<DimensionObject>();

    private bool isInThePast_ = false;
    public bool isInThePast
    {
        get
        {
            return isInThePast_;
        }
        set
        {
            isInThePast_ = value;
            foreach (DimensionObject o in objects)
            {
                updateObject(o);
            }
        }
    }

    void Update()
    {
        if (Input.GetKeyDown(switchKey))
        {
            isInThePast = !isInThePast;
            Timer.Instance.timeLeft -= switchCost;
        }
    }

    void updateObject(DimensionObject o)
    {
        bool active = (o.past && isInThePast) || (o.futur && !isInThePast);
        o.gameObject.SetActive(active);
    }

    public void register(DimensionObject o)
    {
        objects.Add(o);
        updateObject(o);
    }
}

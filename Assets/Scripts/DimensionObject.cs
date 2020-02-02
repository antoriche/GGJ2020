using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DimensionObject : MonoBehaviour
{
    public bool past = false;
    public bool futur = false;
    // Start is called before the first frame update
    void Start()
    {
        DimensionManager.Instance.register(this);
    }
}

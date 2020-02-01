using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KillerTrap : MonoBehaviour
{
    void OnTriggerEnter(Collider c)
    {
        if (c.tag == "Player")
        {
            Player.Instance.Die();
        }
    }
}

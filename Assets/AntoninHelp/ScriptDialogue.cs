using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScriptDialogue : MonoBehaviour
{
    // Start is called before the first frame update
    public Text text;
    public string narration;
    public int used;
    public float waitTimer;
    public float totalWaitTime;
    public bool touch;
    public bool timeLine;
    public bool isInThePast = DimensionManager.Instance.isInThePast;

    void Start()
    {
        touch = false;
        used = 0;
    }

    // Update is called once per frame
    void Update()
    {
        isInThePast = DimensionManager.Instance.isInThePast;
        if(isInThePast == timeLine)
        {
            if (touch == true)
            {
                text.enabled = true;
                waitTimer += Time.deltaTime;
                if (waitTimer >= totalWaitTime)
                {
                    used = 1;
                    text.enabled = false;
                }
            }
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if(used == 0)
        {
            if (other.gameObject.tag == "Player")
            {
                text.text = narration;
                touch = true;
            }
        }

    }
}

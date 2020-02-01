using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor.Animations;

public class Openable : MonoBehaviour
{
    public Key key;
    public AnimatorController closed;
    public AnimatorController opened;

    private bool state_;
    private bool state
    {
        get { return state_; }
        set
        {
            state_ = value;
            AnimatorController anim = state_ ? opened : closed;
            Animator animator = GetComponent<Animator>();
            animator.runtimeAnimatorController = anim;
        }
    }

    void Awake()
    {
        state = key.activated;
    }

    // Update is called once per frame
    void Update()
    {
        if (state != key.activated) state = key.activated;
    }
}

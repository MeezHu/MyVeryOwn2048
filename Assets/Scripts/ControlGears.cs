using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ControlGears : MonoBehaviour
{
    public Animator gearAnimator;
    public bool canRotateGears;

    private void Start()
    {
        canRotateGears = false;
    }

    public void PressedInput()
    {
        if (Input.GetKeyDown(KeyCode.LeftArrow))
        {
            gearAnimator.Play("spinLeft", 0, 0);
            // gearAnimator.SetTrigger("spinLeft");
        }
        
        if (Input.GetKeyDown(KeyCode.UpArrow))
        {
            gearAnimator.Play("spinUp", 0, 0);
            //gearAnimator.SetTrigger("spinUp");
        }
        
        if (Input.GetKeyDown(KeyCode.RightArrow))
        {
            gearAnimator.Play("spinRight", 0, 0);
            //gearAnimator.SetTrigger("spinRight");
        }
        
        if (Input.GetKeyDown(KeyCode.DownArrow))
        {
            gearAnimator.Play("spinDown", 0, 0);
            //gearAnimator.SetTrigger("spinDown");
        }
    }
    
    private void Update()
    {
        if (canRotateGears)
        {
            PressedInput();
        }
    }
}

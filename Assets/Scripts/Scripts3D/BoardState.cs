using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BoardState : State
{
    public FpsState fpsState;
    public static bool canMove = true;


    public override State RunCurrentState()
    {
        if (canMove)
        {
            return fpsState;
        }
        else
        {
            return this;
        }
    }
}

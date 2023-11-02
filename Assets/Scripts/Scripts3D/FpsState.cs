using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FpsState : State
{
    public BoardState boardState;
    public static bool isInBoard = false;


    public override State RunCurrentState()
    {
        if (isInBoard)
        {
            return boardState;
        }
        else
        {
            return this;
        }
    }
}

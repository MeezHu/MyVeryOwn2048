using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StateManager : MonoBehaviour
{
    // ----------------------------------------------------------
    //                         SINGLETON
    // ----------------------------------------------------------

    private static StateManager _instance;

    public static StateManager Instance { get { return _instance; } }


    private void Awake()
    {
        if (_instance != null && _instance != this)
        {
            Destroy(this.gameObject);
        }
        else
        {
            _instance = this;
        }
    }

    // ----------------------------------------------------------
    //                     FIN SINGLETON
    // ----------------------------------------------------------



    public State currentState;

    void Update()
    {
        RunStateMachine();

        if (Input.GetKeyDown(KeyCode.E))
        {
            FpsState.isInBoard = !FpsState.isInBoard;
            BoardState.canMove = !BoardState.canMove;
        }

    }

    private void RunStateMachine()
    {
        State nextState = currentState?.RunCurrentState();

        if (nextState != null )
        {
            SwitchToCurrentState(nextState);
        }
    }

    private void SwitchToCurrentState(State nextState)
    {
        currentState = nextState;
    }
}

using System;
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

    public bool canSwitch;


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

    public bool canPovBoard;
    public bool canPovFps;

    public ControlGears controlGears;
    public HeadBobController headBobController;
    public StepSoundControl stepSoundControl;
    public GameObject eCanvas;

    private void Start()
    {
        canPovBoard = true;
        canPovFps = false;
        headBobController = GetComponent<HeadBobController>();
    }

    void Update()
    {
        RunStateMachine();

        if (Input.GetKeyDown(KeyCode.E) && canSwitch)
        {
            FpsState.isInBoard = !FpsState.isInBoard;
            BoardState.canMove = !BoardState.canMove;

            if (canPovBoard)
            {
                StartCoroutine(CoroutineBoardView());
                if (eCanvas != null)
                {
                    Destroy(eCanvas);
                }
                Debug.Log("Board View");
                headBobController.enabled = false;
                stepSoundControl.enabled = false;
                controlGears.canRotateGears = true;
            }

            if (canPovFps)
            {
                StartCoroutine(CoroutineFpsView());
                Debug.Log("Fps View");
                headBobController.enabled = true;
                stepSoundControl.enabled = true;
                controlGears.canRotateGears = false;
            }
        }

    }

    public void ChangeCanSwitch(bool newState){
        canSwitch = newState;
    }


    public void RunStateMachine()
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
    
    public void BoardView()
    {
        DotweenManager.Instance.MoveCamToBoard();
        canPovBoard = false;
        //canPovFps = true;
    }
    
    public void FpsView()
    {
        DotweenManager.Instance.MoveCamToPlayer();
        canPovFps = false;
        //canPovBoard = true;
    }

    public IEnumerator CoroutineBoardView()
    {
        BoardView();

        yield return new WaitForSeconds(0.2f);
        canPovFps = true;
    }
    
    public IEnumerator CoroutineFpsView()
    {
        FpsView();

        yield return new WaitForSeconds(0.2f);
        canPovBoard = true;
    }
}

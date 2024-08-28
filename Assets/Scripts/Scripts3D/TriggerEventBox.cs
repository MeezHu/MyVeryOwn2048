using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class TriggerEventBox : MonoBehaviour
{
    public UnityEvent inBox;
    public UnityEvent outBox;
    public GameObject eCanvas;

    //public bool canPovBoard;
    //public bool canPovFps;
    
    public void OnTriggerEnter(Collider other){
        inBox.Invoke();
        if(eCanvas != null)
        {
            eCanvas.SetActive(true);
        }
        //canPovBoard = true;
        //canPovFps = true;
    }

    public void OnTriggerExit(Collider other){
        outBox.Invoke();
        if(eCanvas != null)
        {
            eCanvas.SetActive(false);
        }
        //canPovBoard = false;
        //canPovFps = false;
    }

    /*
    public void BoardView()
    {
        DotweenManager.Instance.MoveCamToBoard();
        canPovBoard = false;
        canPovFps = true;
    }
    
    public void FpsView()
    {
        DotweenManager.Instance.MoveCamToPlayer();
        canPovFps = false;
        canPovBoard = true;
    }
    
    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.E) && canPovBoard)
        {
            BoardView();
        }
        
        if (Input.GetKeyDown(KeyCode.E) && canPovFps)
        {
            FpsView();
        }
    }
    */
}

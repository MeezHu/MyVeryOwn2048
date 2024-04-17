using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CamMovement : MonoBehaviour
{
    public Animator cam;
    
    [SerializeField] private bool canOptPanOut;
    [SerializeField] private bool canQuiPanOut;
    [SerializeField] private bool canStaPanOut;
    [SerializeField] private bool canStart;
    
    //================================END OF VARIABLES==============================================

    void Start()
    {
        //cam.speed = 0;
        canOptPanOut = false;
        canStaPanOut = false;
        canQuiPanOut = false;
        canStart = false;

    }
    
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.LeftArrow) && !canOptPanOut)
        {
            Debug.Log("Options");
            OptionPanel();
        }
        
        if (Input.GetKeyDown(KeyCode.Backspace) && canOptPanOut)
        {
            Debug.Log("Quit Options");
            OptionPanelOut();
        }
        
        if (Input.GetKeyDown(KeyCode.RightArrow) && !canQuiPanOut)
        {
            Debug.Log("Wanna Quit?");
            QuitPanel();
        }
        
        if (Input.GetKeyDown(KeyCode.Backspace) && canQuiPanOut)
        {
            Debug.Log("Quit Quit");
            QuitPanelOut();
        }
        
        if (Input.GetKeyDown(KeyCode.UpArrow) && !canStaPanOut)
        {
            Debug.Log("Wanna Play?");
            MoveStartPanel();
        }
        
        if (Input.GetKeyDown(KeyCode.Backspace) && canStaPanOut && canStart)
        {
            Debug.Log("Quit Play");
            MoveStartPanelOut();
        }
        
        if (Input.GetKeyDown(KeyCode.UpArrow) && canStaPanOut && canStart)
        {
            Debug.Log("Play");
            MoveStart();
        }
    }
    
    //================================CAM ANIMATION==============================================
    
    public void MoveStartPanel()
    {
        cam.SetTrigger("MoveStartPanel");
        canStaPanOut = true;
        StartCoroutine(CanStartSecurity());
    }
    
    public void MoveStartPanelOut()
    {
        cam.SetTrigger("MoveStartPanelOut");
        canStaPanOut = false;
        canStart = false;
    }
    
    public void MoveStart()
    {
        cam.SetTrigger("MoveStart");
        canStart = false;
    }
    
    public void OptionPanel()
    {
        cam.SetTrigger("OptionPanel");
        canOptPanOut = true;
    }

    public void OptionPanelOut()
    {
        cam.SetTrigger("OptionPanelOut");
        canOptPanOut = false;
    }
    
    public void QuitPanel()
    {
        cam.SetTrigger("QuitPanel");
        canQuiPanOut = true;
    }
    
    public void QuitPanelOut()
    {
        cam.SetTrigger("QuitPanelOut");
        canQuiPanOut = false;
    }

    private IEnumerator CanStartSecurity()
    {
        yield return new WaitForSeconds(1f);
        canStart = true;

        yield return null;
    }
    
    // public void PU_Go2048scene()
    // {
    //     Debug.Log("Start");
    //     //SceneManager.LoadSceneAsync(1);
    // }
}

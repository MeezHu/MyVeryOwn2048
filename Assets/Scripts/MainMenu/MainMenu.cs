using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class MainMenu : MonoBehaviour
{
    public Canvas menuBase;
    public Canvas startCanvas;
    public Canvas optionsCanvas;
    public Canvas quitCanvas;

    public float tpsEnaOptions;
    public float tpsDisOptions;
    public float tpsEnaMenu;
    public float tpsEnaQuit;
    public float tpsDisQuit;
    public float tpsEnaStart;
    public float tpsDisStart;
    public float tpsStarting;
    
    // public void PU_Go2048scene()
    // {
    //     Debug.Log("Start");
    //     //SceneManager.LoadSceneAsync(1);
    // }

    public void ToStartPanel()
    {
        StartCoroutine(EnableStart());
        menuBase.gameObject.SetActive(false);
    }
    
    public void ToStartPanelOut()
    {
        StartCoroutine(DisableStart());
        StartCoroutine(EnableMenuBase());
    }
    
    public void Starting()
    {
        StartCoroutine(StartingCoroutine());
        startCanvas.gameObject.SetActive(false);
    }
    
    public void ToOptionsPanel()
    {
        StartCoroutine(EnableOptions());
        menuBase.gameObject.SetActive(false);
    }

    public void ToOptionsPanelOut()
    {
        StartCoroutine(DisableOptions());
        StartCoroutine(EnableMenuBase());
    }
    
    public void ToQuitPanel()
    {
        StartCoroutine(EnableQuit());
        menuBase.gameObject.SetActive(false);
    }
    
    public void ToQuitPanelOut()
    {
        StartCoroutine(DisableQuit());
        StartCoroutine(EnableMenuBase());
    }

    public void Quitting()
    {
        Application.Quit();
    }

    public IEnumerator EnableMenuBase()
    {
        yield return new WaitForSeconds(tpsEnaMenu);
        
        menuBase.gameObject.SetActive(true);
    }
    
    public IEnumerator EnableStart()
    {
        yield return new WaitForSeconds(tpsEnaStart);
        
        startCanvas.gameObject.SetActive(true);
    }
    
    public IEnumerator DisableStart()
    {
        yield return new WaitForSeconds(tpsDisStart);
        
        startCanvas.gameObject.SetActive(false);
    }
    
    public IEnumerator EnableOptions()
    {
        yield return new WaitForSeconds(tpsEnaOptions);
        
        optionsCanvas.gameObject.SetActive(true);
    }
    
    public IEnumerator DisableOptions()
    {
        yield return new WaitForSeconds(tpsDisOptions);
        
        optionsCanvas.gameObject.SetActive(false);
    }
    
    public IEnumerator EnableQuit()
    {
        yield return new WaitForSeconds(tpsEnaQuit);
        
        quitCanvas.gameObject.SetActive(true);
    }
    
    public IEnumerator DisableQuit()
    {
        yield return new WaitForSeconds(tpsDisQuit);
        
        quitCanvas.gameObject.SetActive(false);
    }

    public IEnumerator StartingCoroutine()
    {
        yield return new WaitForSeconds(tpsStarting);
        
        //SceneManager.LoadSceneAsync(1);
    }
    
}

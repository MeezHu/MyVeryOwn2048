using System.Collections;
using System.Collections.Generic;
using System.Net.Http.Headers;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class MainMenu : MonoBehaviour
{
    public MusicManager musicManager;
    public OptionsMouseDetect optionsMouseDetect;
    public QuitMouseDetect quitMouseDetect;

    public Canvas menuBase;
    public Canvas startCanvas;
    public Canvas optionsCanvas;
    public Canvas quitCanvas;
    public GameObject blockScreen;
    public Animator textStartAnimator;
    public Animator fadeScreenAnimator;

    public float tpsEnaOptions;
    public float tpsDisOptions;
    public float tpsEnaMenu;
    public float tpsEnaQuit;
    public float tpsDisQuit;
    public float tpsEnaStart;
    public float tpsDisStart;
    public float tpsStarting;

    public GameObject detectBoxOptions;
    public GameObject detectBoxQuit;
    public GameObject detectBoxStart;
    public GameObject RandomBoom;
    public GameObject RandomBoomBack;
    public GameObject RandomCamWhoosh;
    public GameObject StartBoom;
    public GameObject StartEndBoom;
    public GameObject StartRiser;
    public GameObject beginBoom;
    public GameObject music;
    public GameObject OpeningSound1;
    public GameObject OpeningSound2;
    public GameObject OpeningSound3;
    public GameObject OpeningSound4;
    public GameObject OpeningSound5;

    public StartMouseDetect startMouseDetect;

    // public void PU_Go2048scene()
    // {
    //     Debug.Log("Start");
    //     //SceneManager.LoadSceneAsync(1);
    // }

    private void Start()
    {
        Cursor.lockState = CursorLockMode.None;
        if (PlayerPrefs.GetInt("knowspassword") == 1)
        {
            PlayerPrefs.SetInt("knowspassword", 1);
        }
        else
        {
            PlayerPrefs.SetInt("knowspassword", 0);
        }

        Open();
    }

    public void Open()
    {
        StartCoroutine(CoroutineSoundOpening());
    }

    public void ToStartPanel()
    {   
        startMouseDetect.GoAway();
        detectBoxOptions.SetActive(false);
        detectBoxQuit.SetActive(false);
        StartCoroutine(EnableStart());
        menuBase.gameObject.SetActive(false);
    }
    
    public void ToStartPanelOut()
    {
        startMouseDetect.GoBack();
        detectBoxOptions.SetActive(true);
        detectBoxQuit.SetActive(true);
        StartCoroutine(DisableStart());
        StartCoroutine(EnableMenuBase());
    }
    
    public void Starting()
    {
        detectBoxOptions.SetActive(false);
        detectBoxQuit.SetActive(false);
        StartBoom.SetActive(true);
        musicManager.StopMusic();
        StartCoroutine(CoroutineStartingSounds());
        StartCoroutine(StartingCoroutine());
        startCanvas.gameObject.SetActive(false);
    }
    
    public void ToOptionsPanel()
    {
        optionsMouseDetect.stayHovered = true;
        RandomBoom.SetActive(true);
        RandomBoom.SetActive(false);
        StartCoroutine(CoroutineCamWhoosh());
        StartCoroutine(EnableOptions());
        menuBase.gameObject.SetActive(false);
    }

    public void ToOptionsPanelOut()
    {
        optionsMouseDetect.stayHovered = false;
        optionsMouseDetect.emissiveDefault.SetColor("_EmissionColor", Color.Lerp(Color.blue, optionsMouseDetect.defaultColor, 1f));
        RandomBoomBack.SetActive(true);
        RandomBoomBack.SetActive(false);
        StartCoroutine(DisableOptions());
        StartCoroutine(EnableMenuBase());
    }
    
    public void ToQuitPanel()
    {
        quitMouseDetect.stayHovered = true;
        RandomBoom.SetActive(true);
        RandomBoom.SetActive(false);
        StartCoroutine(CoroutineCamWhoosh());
        StartCoroutine(EnableQuit());
        menuBase.gameObject.SetActive(false);
    }
    
    public void ToQuitPanelOut()
    {
        quitMouseDetect.stayHovered = false;
        optionsMouseDetect.emissiveDefault.SetColor("_EmissionColor", Color.Lerp(Color.red, optionsMouseDetect.defaultColor, 1f));
        RandomBoomBack.SetActive(true);
        RandomBoomBack.SetActive(false);
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
        textStartAnimator.SetTrigger("FadeIn");
    }
    
    public IEnumerator DisableStart()
    {

        textStartAnimator.SetTrigger("FadeOut");
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
        
        SceneManager.LoadSceneAsync(1);
    }

    IEnumerator CoroutineStartingSounds()
    {
        yield return new WaitForSeconds(2);
        StartRiser.SetActive(true);

        yield return new WaitForSeconds(4);
        StartEndBoom.SetActive(true);

        yield return new WaitForSeconds(.3f);
        fadeScreenAnimator.SetTrigger("FadeIn");
    }

    IEnumerator CoroutineCamWhoosh()
    {
        yield return new WaitForSeconds(.6f);
        RandomCamWhoosh.SetActive(true);
        RandomCamWhoosh.SetActive(false);
    }

    IEnumerator CoroutineSoundOpening()
    {
        yield return new WaitForSeconds(2);
        OpeningSound1.SetActive(true);

        yield return new WaitForSeconds(1.5f);
        OpeningSound2.SetActive(true);

        yield return new WaitForSeconds(1);
        OpeningSound3.SetActive(true);

        yield return new WaitForSeconds(0.5f);
        OpeningSound4.SetActive(true);

        yield return new WaitForSeconds(0.5f);
        beginBoom.SetActive(true);
        menuBase.gameObject.SetActive(true);
        musicManager.enabled = true;
        OpeningSound5.SetActive(true);
        blockScreen.SetActive(false);
    }
    
}

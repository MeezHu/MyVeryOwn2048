using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UniqueEventsManager : MonoBehaviour
{
    // ----------------------------------------------------------
    //                         SINGLETON
    // ----------------------------------------------------------

    private static UniqueEventsManager _instance;

    public static UniqueEventsManager Instance {  get { return _instance; } }

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
    //                         SINGLETON
    // ----------------------------------------------------------

    public FlickerControl[] flickerControlList;
    public bool canStartFlicker = true;
    public bool canBecomeRed = true;

    
    public GameObject landLight1;
    public GameObject landLight2;
    public GameObject landLight3;
    public GameObject landLight4;
    public GameObject doorLight1;
    public GameObject doorLight2;
    public GameObject doorLight3;
    public GameObject doorLight4;
    public GameObject gvYellow;
    public GameObject Ambiance1;
    public GameObject reflecProb1;

    public GameObject landLightR1;
    public GameObject landLightR2;
    public GameObject landLightR3;
    public GameObject landLightR4;
    public GameObject doorLightR1;
    public GameObject doorLightR2;
    public GameObject doorLightR3;
    public GameObject doorLightR4;
    public GameObject gvRed;
    public GameObject Ambiance2;
    public GameObject LightsOnRed;
    public GameObject reflecProb2;

    public GameObject[] vfxSteamEnviro;
    public GameObject vfxFinal1;
    public GameObject vfxFinal2;
    public float vfxDelay = 2;

    public StateManager stateManager;
    public ControlGears controlGears;
    public GameObject triggerBoxRange;



    [ContextMenu("BecomeRed()")]
    public void BecomeRed()
    {
        canBecomeRed = false;
        StartCoroutine(CoroutineTurningRed());
    }

    public void StartFlickeringLight()
    {
        Debug.Log("StartFlickeringLight");
        foreach (FlickerControl flicker in flickerControlList)
        {
            flicker.enabled = true;
        }
        canStartFlicker = false;

        //if (canStartFlicker)
        //{
        //    canStartFlicker = false;
        //    Debug.Log("StartFlickeringLight");
        //    foreach(FlickerControl flicker in flickerControlList)
        //    {
        //        flicker.enabled = true;
        //    }
        //}
    }

    [ContextMenu("GameOverEvent")]
    public void GameOverEvent()
    {
        StartCoroutine(CoroutineGameOverEvent());
        triggerBoxRange.SetActive(false);
        stateManager.canSwitch = false;
        controlGears.canRotateGears = false;
        FpsState.isInBoard = !FpsState.isInBoard;
        BoardState.canMove = !BoardState.canMove;
        StartCoroutine(stateManager.CoroutineFpsView());
        //stateManager.canPovBoard = false;
    }

    IEnumerator CoroutineGameOverEvent()
    {
        foreach(GameObject vfx in vfxSteamEnviro)
        {
            yield return new WaitForSeconds(vfxDelay);
            vfx.gameObject.SetActive(true);
            vfxDelay = vfxDelay - 0.2f;
        }

        yield return new WaitForSeconds(0.5f);
        vfxFinal1.SetActive(true);
        vfxFinal2.SetActive(true);
    }

    IEnumerator CoroutineTurningRed()
    {
        yield return new WaitForSeconds(1);
        landLight1.SetActive(false);
        landLight2.SetActive(false);
        landLight3.SetActive(false);
        landLight4.SetActive(false);
        doorLight1.SetActive(false);
        doorLight2.SetActive(false);
        doorLight3.SetActive(false);
        doorLight4.SetActive(false);
        gvYellow.SetActive(false);
        reflecProb1.SetActive(false);
        Ambiance1.SetActive(false);

        doorLightR1.SetActive(true);
        doorLightR2.SetActive(true);
        doorLightR3.SetActive(true);
        doorLightR4.SetActive(true);
        gvRed.SetActive(true);

        yield return new WaitForSeconds(4);
        landLightR1.SetActive(true);
        landLightR2.SetActive(true);
        landLightR3.SetActive(true);
        landLightR4.SetActive(true);
        doorLightR4.SetActive(true);
        LightsOnRed.SetActive(true);
        reflecProb2.SetActive(true);
        Ambiance2.SetActive(true);
    }

    void Start()
    {
        
    }

    void Update()
    {
        if (vfxDelay < 0.3f)
        {
            vfxDelay = 0.3f;
        }
    }
}

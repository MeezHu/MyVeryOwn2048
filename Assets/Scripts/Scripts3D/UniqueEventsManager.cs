using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

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

    public HeadBobController headBobController;
    public StepSoundControl stepSoundControl;
    public CharacterController characterController;

    public GameObject boxPasswordSpawn;
    public GameObject secretLocationHintHard;
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

    public GameObject gameOverSound;
    public GameObject gameOverRiser;
    public GameObject stopEverything;
    public GameObject blockingPipes;

    public DoorNoiseSoftControl doorNoiseSoftControl;
    public DoorNoiseHardControl doorNoiseHardControl;
    public Animator whiteFadeAnimator;

    public HardFlickerControl redFlicker1;
    public HardFlickerControl redFlicker2;
    public HardFlickerControl redFlicker3;
    public HardFlickerControl redFlicker4;
    public GameObject gridBoard;
    public GameObject blockerPipes;
    public GameObject boardGears;
    public GameObject endCanvas;

    [Header("Lock Animators")]
    public Animator verrou1Animator;
    public Animator verrou2Animator;
    public Animator verrou3Animator;
    public Animator verrou4Animator;
    public Animator verrou5Animator;
    public Animator doorAnimator;
    public Animator boardAnimator;

    [Header("Lock Sounds")]
    public bool canVerrou1 = true;
    public bool canVerrou2 = true;
    public bool canVerrou3 = true;
    public bool canVerrou4 = true;
    public GameObject mechaPreparing1;
    public GameObject mechaWorking1;
    public GameObject mechaEndClick1;
    public GameObject mechaPreparing2;
    public GameObject mechaWorking2;
    public GameObject mechaEndClick2;
    public GameObject mechaUnlock1;
    public GameObject mechaUnlockSteamy1;
    public GameObject mechaWorkingLight1;
    public GameObject mechaEndClickLight1;
    public GameObject mechaUnlock2;
    public GameObject mechaUnlockSteamy2;
    public GameObject mechaWorkingLight2;
    public GameObject mechaEndClickLight2;
    public GameObject mechaUnlockSteamy3;
    public GameObject mechaWorkingLight3;
    public GameObject mechaEndClickLight3;
    public GameObject DoorOpen1;
    public GameObject DoorOpen2;
    public GameObject DoorOpen3;
    public GameObject DoorOpen4;
    public GameObject winRiser;
    public GameObject winEndSound;

    public void WinEvent()
    {
        headBobController.enabled = true;
        stepSoundControl.enabled = true;
        triggerBoxRange.SetActive(false);
        stateManager.canSwitch = false;
        controlGears.canRotateGears = false;
        FpsState.isInBoard = !FpsState.isInBoard;
        BoardState.canMove = !BoardState.canMove;
        StartCoroutine(stateManager.CoroutineFpsView());
        StartCoroutine(CoroutineWinEvent());
        blockerPipes.SetActive(true);
    }

    IEnumerator CoroutineWinEvent()
    {
        Ambiance2.SetActive(false);
        yield return new WaitForSeconds(2);
        boardAnimator.SetTrigger("Go");
        boardGears.SetActive(false);
        gridBoard.SetActive(false);

        yield return new WaitForSeconds(3f);
        doorAnimator.SetTrigger("Open");
        DoorOpen1.SetActive(true);
        DoorOpen1.SetActive(false);
        DoorOpen2.SetActive(true);
        DoorOpen2.SetActive(false);
        DoorOpen3.SetActive(true);
        DoorOpen3.SetActive(false);

        yield return new WaitForSeconds(3);
        DoorOpen4.SetActive(true);
        DoorOpen4.SetActive(false);

        yield return new WaitForSeconds(9);
        redFlicker1.enabled = true;
        redFlicker2.enabled = true;
        redFlicker3.enabled = true;
        redFlicker4.enabled = true;

        yield return new WaitForSeconds(3);
        winRiser.SetActive(true);
        winRiser.SetActive(false);
        characterController.enabled = false;
        headBobController.enabled = false;
        stepSoundControl.stepSoundPlaying = false;
        //stepSoundControl.enabled = false;

        yield return new WaitForSeconds(3.5f);
        winEndSound.SetActive(true);
        winEndSound.SetActive(false);

        yield return new WaitForSeconds(1.3f);
        //characterController.enabled = false;
        //headBobController.enabled = false;
        //stepSoundControl.enabled = false;
        endCanvas.SetActive(true);

        yield return new WaitForSeconds(0.4f);
        SceneManager.LoadScene(0);

    }

    public void Unlock1()
    {
        if (canVerrou1)
        {
            canVerrou1 = false;
            StartCoroutine(CoroutineUnlock1());
        }
    }

    IEnumerator CoroutineUnlock1()
    {
        yield return new WaitForSeconds(1);
        mechaPreparing1.SetActive(true);
        mechaPreparing1.SetActive(false);

        yield return new WaitForSeconds(0.3f);
        mechaWorking1.SetActive(true);
        mechaWorking1.SetActive(false);
        verrou1Animator.SetTrigger("Go");

        yield return new WaitForSeconds(5);
        mechaEndClick1.SetActive(true);
        mechaEndClick1.SetActive(false);
    }

    public void Unlock2()
    {
        if (canVerrou2)
        {
            canVerrou2 = false;
            StartCoroutine(CoroutineUnlock2());
        }
    }

    IEnumerator CoroutineUnlock2()
    {
        yield return new WaitForSeconds(1);
        mechaPreparing2.SetActive(true);
        mechaPreparing2.SetActive(false);

        yield return new WaitForSeconds(0.3f);
        mechaWorking2.SetActive(true);
        mechaWorking2.SetActive(false);
        verrou2Animator.SetTrigger("Go");

        yield return new WaitForSeconds(5);
        mechaEndClick2.SetActive(true);
        mechaEndClick2.SetActive(false);
    }

    public void Unlock3()
    {
        if (canVerrou3)
        {
            canVerrou3 = false;
            StartCoroutine(CoroutineUnlock3());
        }
    }

    IEnumerator CoroutineUnlock3()
    {
        yield return new WaitForSeconds(1);
        mechaUnlock1.SetActive(true);
        mechaUnlock1.SetActive(false);
        verrou3Animator.SetTrigger("Go");

        yield return new WaitForSeconds(1.2f);
        mechaUnlockSteamy1.SetActive(true);
        mechaUnlockSteamy1.SetActive(false);

        yield return new WaitForSeconds(1.3f);
        mechaWorkingLight1.SetActive(true);
        mechaWorkingLight1.SetActive(false);

        yield return new WaitForSeconds(3f);
        mechaEndClickLight1.SetActive(true);
        mechaEndClickLight1.SetActive(false);
    }

    public void Unlock4()
    {
        if (canVerrou4)
        {
            canVerrou4 = false;
            StartCoroutine(CoroutineUnlock4());
        }
    }

    IEnumerator CoroutineUnlock4()
    {
        yield return new WaitForSeconds(1);
        mechaUnlock2.SetActive(true);
        mechaUnlock2.SetActive(false);
        verrou4Animator.SetTrigger("Go");

        yield return new WaitForSeconds(1.2f);
        mechaUnlockSteamy2.SetActive(true);
        mechaUnlockSteamy2.SetActive(false);

        yield return new WaitForSeconds(1.3f);
        mechaWorkingLight2.SetActive(true);
        mechaWorkingLight2.SetActive(false);

        yield return new WaitForSeconds(3f);
        mechaEndClickLight2.SetActive(true);
        mechaEndClickLight2.SetActive(false);
    }

    //public void Unlock5()
    //{
    //    StartCoroutine(CoroutineUnlock5());
    //}

    //IEnumerator CoroutineUnlock5()
    //{
    //    yield return new WaitForSeconds(1);
    //    verrou5Animator.SetTrigger("Go");
    //}

    [ContextMenu("StartDoorNoiseSoft")]
    public void StartDoorNoiseSoft()
    {
        doorNoiseSoftControl.enabled = true;
    }

    [ContextMenu("StoptDoorNoiseSoft")]
    public void StopDoorNoiseSoft()
    {
        doorNoiseSoftControl.enabled = false;
    }

    [ContextMenu("StartDoorNoiseHard")]
    public void StartDoorNoiseHard()
    {
        StartCoroutine(CoroutineStartDoorNoiseHard());
    }

    IEnumerator CoroutineStartDoorNoiseHard()
    {
        yield return new WaitForSeconds(1.7f);
        doorNoiseHardControl.enabled = true;
    }

    [ContextMenu("StopDoorNoiseHard")]
    public void StopDoorNoiseHard()
    {
        doorNoiseHardControl.enabled = false;
    }

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
        headBobController.enabled = true;
        stepSoundControl.enabled = true;
        blockingPipes.SetActive(true);
        StartCoroutine(CoroutineGameOverEvent());
        StartCoroutine(CoroutineGameOverSound());
        StartCoroutine(CoroutineGameOverRiser());
        triggerBoxRange.SetActive(false);
        stateManager.canSwitch = false;
        controlGears.canRotateGears = false;
        FpsState.isInBoard = !FpsState.isInBoard;
        BoardState.canMove = !BoardState.canMove;
        StartCoroutine(stateManager.CoroutineFpsView());
        //stateManager.canPovBoard = false;
    }

    IEnumerator CoroutineGameOverRiser()
    {
        yield return new WaitForSeconds(3f);
        gameOverRiser.SetActive(true);

    }

    IEnumerator CoroutineGameOverSound()
    {
        yield return new WaitForSeconds(6f);
        gameOverSound.SetActive(true);
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

        yield return new WaitForSeconds(1.5f);
        whiteFadeAnimator.SetTrigger("FadeIn");

        yield return new WaitForSeconds(3f);
        SceneManager.LoadScene(2);
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

        yield return new WaitForSeconds(1.3f);
        verrou5Animator.SetTrigger("Go");
        mechaUnlockSteamy3.SetActive(true);
        mechaUnlockSteamy3.SetActive(false);

        yield return new WaitForSeconds(1f);
        mechaWorkingLight3.SetActive(true);
        mechaWorkingLight3.SetActive(false);

        yield return new WaitForSeconds(3);
        mechaEndClickLight3.SetActive(true);
        mechaEndClickLight3.SetActive(false);

        yield return new WaitForSeconds(4.5f);
        secretLocationHintHard.SetActive(true);
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
        doorNoiseSoftControl = GetComponent<DoorNoiseSoftControl>();
        doorNoiseHardControl = GetComponent<DoorNoiseHardControl>();
    }

    void Update()
    {
        if (vfxDelay < 0.3f)
        {
            vfxDelay = 0.3f;
        }
    }
}

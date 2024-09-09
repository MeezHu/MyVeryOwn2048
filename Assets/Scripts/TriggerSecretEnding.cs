using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriggerSecretEnding : MonoBehaviour
{
    public Animator secretWolfAnimator;
    public Animator secretBoardAnimator;
    public LightRainbowSolo rainbowSolo1;
    public LightRainbowSolo rainbowSolo2;
    public LightRainbowSolo rainbowSolo3;
    public LightRainbowSolo rainbowSolo4;
    public LightRainbowSolo rainbowSoloR1;
    public LightRainbowSolo rainbowSoloR2;
    public LightRainbowSolo rainbowSoloR3;
    public LightRainbowSolo rainbowSoloR4;
    public ClongControl clongControl;
    public GameObject gridBoard;
    public GameObject engrenages;
    public GameObject boxRangeBoard;
    public GameObject landLight1;
    public GameObject landLight2;
    public GameObject landLight3;
    public GameObject landLight4;
    public GameObject landLight5;
    public GameObject landLight6;
    public GameObject landLightR1;
    public GameObject landLightR2;
    public GameObject landLightR3;
    public GameObject landLightR4;
    public GameObject rainbowLight1;
    public GameObject rainbowLight2;
    public GameObject rainbowLight3;
    public GameObject rainbowLight4;
    public GameObject ambiantSound;
    public GameObject ambiantSound2;
    public GameObject secretMusicStart;
    public GameObject secretMusicContinue;
    public GameObject triggerLightsNormal;
    public DoorNoiseSoftControl softDoorSounds;
    public DoorNoiseHardControl hardDoorSounds;
    public GameObject globalVolumeNormal;
    public GameObject globalvolumeRed;
    public GameObject phareNormal;
    public GameObject phareRainbow;
    public bool canSecretEnding = true;
    public GameObject DoorOpen1;
    public GameObject DoorOpen2;
    public GameObject DoorOpen3;
    public GameObject DoorOpen4;

    [Header("Lock Animators")]
    public Animator verrou1Animator;
    public Animator verrou2Animator;
    public Animator verrou3Animator;
    public Animator verrou4Animator;
    public Animator verrou5Animator;
    public Animator doorAnimator;

    public void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player" && canSecretEnding)
        {
            canSecretEnding = false;
            Debug.Log("SECRET ENDING!");
            StartCoroutine(CouroutineSecretEndingLights());
            //gameObject.SetActive(false);
        }
    }

    IEnumerator CouroutineSecretEndingLights()
    {
        if (StateManager.Instance != null)
        {
            StateManager.Instance.canSwitch = false;
        }

        secretBoardAnimator.SetTrigger("Go");
        verrou1Animator.SetTrigger("Go");
        verrou2Animator.SetTrigger("Go");
        verrou3Animator.SetTrigger("Go");
        verrou4Animator.SetTrigger("Go");
        verrou5Animator.SetTrigger("Go");
        engrenages.SetActive(false);
        gridBoard.SetActive(false);
        landLight1.SetActive(false);
        landLight2.SetActive(false);
        landLight3.SetActive(false);
        landLight4.SetActive(false);
        landLight5.SetActive(false);
        landLight6.SetActive(false);
        landLightR1.SetActive(false);
        landLightR2.SetActive(false);
        landLightR3.SetActive(false);
        landLightR4.SetActive(false);
        softDoorSounds.canNoise = false;
        hardDoorSounds.canNoise = false;
        clongControl.canClong = false;
        boxRangeBoard.SetActive(false);
        ambiantSound.SetActive(false);
        ambiantSound2.SetActive(false);
        boxRangeBoard.SetActive(false);
        triggerLightsNormal.SetActive(false);

        yield return new WaitForSeconds(3f);
        doorAnimator.SetTrigger("Open");
        DoorOpen1.SetActive(true);
        DoorOpen2.SetActive(true);
        DoorOpen3.SetActive(true);

        yield return new WaitForSeconds(3f);
        DoorOpen4.SetActive(true);
        DoorOpen4.SetActive(false);

        yield return new WaitForSeconds(5f);
        secretWolfAnimator.SetTrigger("Arise");

        yield return new WaitForSeconds(6f);

        //musique
        secretMusicStart.SetActive(true);
        yield return new WaitForSeconds(2f);

        secretWolfAnimator.SetTrigger("Spin");
        phareNormal.SetActive(false);
        phareRainbow.SetActive(true);
        globalvolumeRed.SetActive(false);
        globalVolumeNormal.SetActive(true);
        rainbowLight1.SetActive(true);
        rainbowLight2.SetActive(true);
        rainbowLight3.SetActive(true);
        rainbowLight4.SetActive(true);
        boxRangeBoard.SetActive(true);
        rainbowSolo1.enabled = true;
        rainbowSolo2.enabled = true;
        rainbowSolo3.enabled = true;
        rainbowSolo4.enabled = true;
        rainbowSoloR1.enabled = true;
        rainbowSoloR2.enabled = true;
        rainbowSoloR3.enabled = true;
        rainbowSoloR4.enabled = true;

        yield return new WaitForSeconds(42);
        secretMusicContinue.SetActive(true);
    }
}

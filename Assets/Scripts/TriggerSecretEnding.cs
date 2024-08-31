using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriggerSecretEnding : MonoBehaviour
{
    public uint Ambiant1;

    public LightRainbowSolo rainbowSolo1;
    public LightRainbowSolo rainbowSolo2;
    public LightRainbowSolo rainbowSolo3;
    public LightRainbowSolo rainbowSolo4;
    public LightRainbowSolo rainbowSoloR1;
    public LightRainbowSolo rainbowSoloR2;
    public LightRainbowSolo rainbowSoloR3;
    public LightRainbowSolo rainbowSoloR4;
    public ClongControl clongControl;
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
    public GameObject triggerLightsNormal;
    public DoorNoiseSoftControl softDoorSounds;
    public DoorNoiseHardControl hardDoorSounds;
    public GameObject globalVolumeNormal;
    public GameObject globalvolumeRed;
    public bool canSecretEnding = true;

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
    }
}

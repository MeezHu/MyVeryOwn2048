using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StepSoundControl : MonoBehaviour
{
    public GameObject[] stepSounds;
    public float repeatTime;
    public bool canStepSound;
    public bool canContinueStepSound;
    

    void Start()
    {

    }

    public void StepSound()
    {
        canStepSound = false;
        StartCoroutine(CoroutineStepSound());
    }

    IEnumerator CoroutineStepSound()
    {
        yield return new WaitForSeconds(0.2f);
        int randomStep = Random.Range(0, stepSounds.Length);
        stepSounds[randomStep].SetActive(true);
        yield return new WaitForSeconds(0.1f);
        stepSounds[randomStep].SetActive(false);

        yield return new WaitForSeconds(repeatTime);
        
        if (canContinueStepSound)
        {
            StartCoroutine(CoroutineStepSound());
        }
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Z) || Input.GetKeyDown(KeyCode.Q) || Input.GetKeyDown(KeyCode.S) || Input.GetKeyDown(KeyCode.D))
        {
            StepSound();
            canContinueStepSound = true;
            //canStepSound = false;
        }

        if (Input.GetKeyUp(KeyCode.Z) || Input.GetKeyDown(KeyCode.Q) || Input.GetKeyDown(KeyCode.S) || Input.GetKeyDown(KeyCode.D))
        {
            canStepSound = true;
            canContinueStepSound = false;
            //StopCoroutine(CoroutineStepSound());
        }
        
    }
}

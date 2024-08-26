using JetBrains.Annotations;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class StepSoundControl : MonoBehaviour
{
    public GameObject[] stepSounds;
    public float repeatTime;
    public bool canStepSound = true;
    public bool canContinueStepSound;
    public bool stepSoundPlaying = false;
    

    void Start()
    {
        InvokeRepeating("StepSound", 1, 1);
    }

    public void StepSound()
    {
        
        if (stepSoundPlaying)
        {
            int randomStep = Random.Range(0, stepSounds.Length);
            stepSounds[randomStep].SetActive(true);
            stepSounds[randomStep].SetActive(false);
        }
    } 

    void Update()
    {
        if (Input.GetKey(KeyCode.Z) || Input.GetKey(KeyCode.Q) || Input.GetKey(KeyCode.S) || Input.GetKey(KeyCode.D))
        {
            stepSoundPlaying = true;
        }
        else
        {
            stepSoundPlaying = false;
        }
    }
}

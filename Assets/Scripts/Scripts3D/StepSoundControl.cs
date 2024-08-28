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

    public float toggleSpeed;
    public CharacterController characterController;
    

    void Start()
    {
        InvokeRepeating("StepSound", 1, 1);
    }

    public void StepSoundPlayingEnabler()
    {
        float speed = new Vector3(characterController.velocity.x, 0, characterController.velocity.z).magnitude;
        if (speed < toggleSpeed) return;

        stepSoundPlaying = true;
    }

    public void StepSoundPlayingDisabler()
    {
        float speed = new Vector3(characterController.velocity.x, 0, characterController.velocity.z).magnitude;
        if (speed > toggleSpeed) return;

        stepSoundPlaying = false;
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
        //if (Input.GetKey(KeyCode.Z) || Input.GetKey(KeyCode.Q) || Input.GetKey(KeyCode.S) || Input.GetKey(KeyCode.D))
        //{
        //    stepSoundPlaying = true;
        //}
        //else
        //{
        //    stepSoundPlaying = false;
        //}

        StepSoundPlayingEnabler();

        StepSoundPlayingDisabler();
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FadeController : MonoBehaviour
{
    public Animator fadeAnimator;
    public Animator camGetUpAnimator;
    public GameObject openingAmbiance;
    public GameObject loopingAmbiance;
    public GameObject fallSounds;

    public PlayerMovement playerMovement;
    public MouseLook mouseLook;
    public HeadBobController headBobController;
    public StepSoundControl stepSoundControl;

    void Start()
    {
        Cursor.lockState = CursorLockMode.Locked;

        fadeAnimator = GetComponent<Animator>();

        Invoke("StartFallSound", 2);
        Invoke("OpeningFadeOut", 11);
        Invoke("GettingUp", 15);
        Invoke("ActivatePlayer", 21);
        Invoke("LoopingAmbiance", 32); //21
    }

    public void StartFallSound()
    {
        fallSounds.SetActive(true);
    }

    public void OpeningFadeOut()
    {
        fadeAnimator.SetTrigger("FadeOut");
        openingAmbiance.SetActive(true);

    }

    public void ActivatePlayer()
    {
        playerMovement.enabled = true;
        mouseLook.enabled = true;
        headBobController.enabled = true;
        stepSoundControl.enabled = true;
        camGetUpAnimator.enabled = false;
    }

    public void GettingUp()
    {
        camGetUpAnimator.SetTrigger("CamGettingUp");
    }

    public void LoopingAmbiance()
    {
        loopingAmbiance.SetActive(true);
    }
}

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
    public GameObject landLight1;
    public GameObject landLight2;
    public GameObject landLight3;
    public GameObject landLight4;

    public PlayerMovement playerMovement;
    public MouseLook mouseLook;
    public HeadBobController headBobController;
    public StepSoundControl stepSoundControl;

    void Start()
    {
        Cursor.lockState = CursorLockMode.Locked;

        fadeAnimator = GetComponent<Animator>();

        Invoke("StartFallSound", 2);
        Invoke("ActivateLights", 7);
        Invoke("OpeningFadeOut", 11);
        Invoke("GettingUp", 15);
        Invoke("ActivatePlayer", 21);
        Invoke("LoopingAmbiance", 32); //21

        if (PlayerPrefs.GetFloat("sensitivity") == 0)
        {
            PlayerPrefs.SetFloat("sensitivity", 0.5f);
        }

        if (PlayerPrefs.GetFloat("volume") == 0)
        {
            PlayerPrefs.SetFloat("volume", 0.5f);
        }
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

    public void ActivateLights()
    {
        landLight1.SetActive(true);
        landLight2.SetActive(true);
        landLight3.SetActive(true);
        landLight4.SetActive(true);
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

using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class VolumeSliderController : MonoBehaviour
{
    public Button phantomVolume;
    public Button phantomSensitivity;
    public Button phantomMainMenu;
    public Button phantomExit;
    public Button phantomRetry;

    public GameObject volumeBar;
    public GameObject sensitivityBar;
    public GameObject startPosVolume;
    public GameObject endPosVolume;
    public GameObject startPosSensitivity;
    public GameObject endPosSensitivity;
    public GameObject mainMenuImage;
    public GameObject ExitImage;
    public GameObject RetryImage;

    public Slider VolumeSlider;
    public Slider SensitivitySlider;

    [Range(0, 1f)] public float volumeLerpValue;

    void Start()
    {
        phantomVolume.Select();
    }

    void Update()
    {
        volumeBar.transform.position = Vector3.Lerp(startPosVolume.transform.position, endPosVolume.transform.position, VolumeSlider.value);
        sensitivityBar.transform.position = Vector3.Lerp(startPosSensitivity.transform.position, endPosSensitivity.transform.position, SensitivitySlider.value);
        MasterVolumeReminder.Instance.volumeMaster = VolumeSlider.value * 100;
        AkSoundEngine.SetRTPCValue("MasterVolume", MasterVolumeReminder.Instance.volumeMaster);


        if ((EventSystem.current.currentSelectedGameObject == phantomVolume.gameObject))
        {
            if (Input.GetKey(KeyCode.LeftArrow))
            {
                VolumeSlider.value -= 0.5f * Time.deltaTime;
            }
            if (Input.GetKey(KeyCode.RightArrow))
            {
                VolumeSlider.value += 0.5f * Time.deltaTime;
            }
        }

        if ((EventSystem.current.currentSelectedGameObject == phantomSensitivity.gameObject))
        {
            if (Input.GetKey(KeyCode.LeftArrow))
            {
                SensitivitySlider.value -= 0.5f * Time.deltaTime;
            }
            if (Input.GetKey(KeyCode.RightArrow))
            {
                SensitivitySlider.value += 0.5f * Time.deltaTime;
            }
        }

        if (EventSystem.current.currentSelectedGameObject == phantomMainMenu.gameObject)
        {
            mainMenuImage.SetActive(true);
        }
        else
        {
            mainMenuImage.SetActive(false);
        }

        if (EventSystem.current.currentSelectedGameObject == phantomExit.gameObject)
        {
            ExitImage.SetActive(true);
        }
        else { ExitImage.SetActive(false); }

        if (EventSystem.current.currentSelectedGameObject == phantomRetry.gameObject)
        {
            RetryImage.SetActive(true);
        }
        else
        {
            RetryImage.SetActive(false);
        }
    }
}

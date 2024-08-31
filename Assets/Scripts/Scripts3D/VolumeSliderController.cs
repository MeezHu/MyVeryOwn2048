using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class VolumeSliderController : MonoBehaviour
{
    public RetryCheck retryCheck;
    public PauseMenuController pauseMenuController;

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
    public float rememberVolume;
    public float rememberSensitivity;

    [Range(0, 1f)] public float volumeLerpValue;

    void Start()
    {
        phantomVolume.Select();
        retryCheck = GetComponent<RetryCheck>();

        rememberVolume = PlayerPrefs.GetFloat("volume");
        //rememberSensitivity = PlayerPrefs.GetFloat("sensitivity");
        VolumeSlider.value = rememberVolume;
        //SensitivitySlider.value = rememberSensitivity;

        //rememberVolume = PlayerPrefs.GetFloat("volume");
        //VolumeSlider.value = rememberVolume;

        //VolumeSlider.value = MasterVolumeReminder.Instance.volumeMaster / 100;
        
    }

    void Update()
    {
        Debug.Log(PlayerPrefs.GetFloat("volume"));
        rememberVolume = VolumeSlider.value;
        PlayerPrefs.SetFloat("volume", rememberVolume);
        PlayerPrefs.SetFloat("sensitivity", SensitivitySlider.value);
        //rememberSensitivity = SensitivitySlider.value;
        //PlayerPrefs.SetFloat("sensitivity", rememberSensitivity);

        if (SensitivitySlider.value == 0)
        {
            SensitivitySlider.value = 0.1f;
        }

        volumeBar.transform.position = Vector3.Lerp(startPosVolume.transform.position, endPosVolume.transform.position, VolumeSlider.value);
        sensitivityBar.transform.position = Vector3.Lerp(startPosSensitivity.transform.position, endPosSensitivity.transform.position, SensitivitySlider.value);
        MasterVolumeReminder.Instance.volumeMaster = VolumeSlider.value * 100;
        AkSoundEngine.SetRTPCValue("MasterVolume", VolumeSlider.value * 100);


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
            if (retryCheck.canRetry == false)
            {
                retryCheck.noRetryButton.SetActive(true);
            }
            if (retryCheck.canRetry == true)
            {
                if (Input.GetKeyDown(KeyCode.Return))
                {
                    if (StateManager.Instance.canPovFps)
                    {
                        FpsState.isInBoard = !FpsState.isInBoard;
                        BoardState.canMove = !BoardState.canMove;
                    }
                    pauseMenuController.Retry();
                }
                RetryImage.SetActive(true);
            }
        }
        else
        {
            RetryImage.SetActive(false);
            retryCheck.noRetryButton.SetActive(false);
        }

        if (EventSystem.current.currentSelectedGameObject == null && Input.GetKeyDown(KeyCode.DownArrow))
        {
            phantomVolume.Select();
        }
    }
}

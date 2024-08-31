using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RememberSensitivity : MonoBehaviour
{
    public MouseLook mouseLook;
    public VolumeSliderController volumeSliderController;
    public float rememberSensitivity;
    public bool lockSliderSensi = true;

    private void Awake()
    {
        //PlayerPrefs.SetFloat("sensitivity", mouseLook.mouseSensitivity);
    }

    void Start()
    {
        //PlayerPrefs.SetFloat("sensitivity", rememberSensitivity);
        //PlayerPrefs.SetFloat("sentitivity", 0);
    }

    void Update()
    {
        //PlayerPrefs.SetFloat("sensitivity", rememberSensitivity);

        if (lockSliderSensi && volumeSliderController.SensitivitySlider.value != 0)
        {
            volumeSliderController.SensitivitySlider.value = PlayerPrefs.GetFloat("sensitivity");
        }

        rememberSensitivity = volumeSliderController.SensitivitySlider.value;

        Debug.Log(PlayerPrefs.GetFloat("sensitivity"));
    }

    
}

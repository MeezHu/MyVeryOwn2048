using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SensitivitySliderMainMenu : MonoBehaviour
{
    public GameObject sensitivityBar;
    public GameObject startSensPos;
    public GameObject endSensPos;

    public Slider sensitivitySlider;

    void Start()
    {
        if (SensitivityReminder.Instance.sensitivityValue != 0)
        {
            sensitivitySlider.value = SensitivityReminder.Instance.sensitivityValue / 100;
        }
    }

    void Update()
    {
        sensitivityBar.transform.position = Vector3.Lerp(startSensPos.transform.position, endSensPos.transform.position, sensitivitySlider.value);
        SensitivityReminder.Instance.sensitivityValue = sensitivitySlider.value * 100;
        AkSoundEngine.SetRTPCValue("MasterVolume", SensitivityReminder.Instance.sensitivityValue);

    }
}

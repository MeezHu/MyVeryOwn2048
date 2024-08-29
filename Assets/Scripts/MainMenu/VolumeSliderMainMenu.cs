using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class VolumeSliderMainMenu : MonoBehaviour
{
    public GameObject volumeBar;
    public GameObject startVolPos;
    public GameObject endVolPos;
    public float rememberVolume;

    public Slider volumeSlider;

    void Start()
    {
        PlayerPrefs.SetFloat("volume", rememberVolume);
        rememberVolume = PlayerPrefs.GetFloat("volume");

        //if (MasterVolumeReminder.Instance.volumeMaster != 0)
        //{
        //    volumeSlider.value = MasterVolumeReminder.Instance.volumeMaster / 100;
        //}
    }

    void Update()
    {
        rememberVolume = volumeSlider.value;
        PlayerPrefs.SetFloat("volume", rememberVolume);
        rememberVolume = PlayerPrefs.GetFloat("volume");
        volumeBar.transform.position = Vector3.Lerp(startVolPos.transform.position, endVolPos.transform.position, volumeSlider.value);
        //MasterVolumeReminder.Instance.volumeMaster = volumeSlider.value * 100;
        AkSoundEngine.SetRTPCValue("MasterVolume", volumeSlider.value * 100);

        Debug.Log(PlayerPrefs.GetFloat("volume"));

    }
}

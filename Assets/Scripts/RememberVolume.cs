using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class RememberVolume : MonoBehaviour
{
    public float rememberVolume;
    public Slider volumeSlider;

    void Start()
    {
        rememberVolume = PlayerPrefs.GetFloat("volume");
        volumeSlider.value = rememberVolume;
        
    }

    void Update()
    {
        AkSoundEngine.SetRTPCValue("MasterVolume", rememberVolume * 100);
        PlayerPrefs.SetFloat("volume", rememberVolume);
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LightRainbow : MonoBehaviour
{
    public Light light1;
    public Light light2;
    public Light light3;
    public Material emissive;
    public float evolutionColorTime;
    public float hue;
    public float saturation;
    public float value;

    void Start()
    {

    }

    void Update()
    {
        evolutionColorTime += Time.deltaTime;

        if(evolutionColorTime >= 2f)
        {
            evolutionColorTime = 0;
        }

        emissive.SetColor("_EmissionColor", Color.HSVToRGB(evolutionColorTime / 2, saturation / 100, value / 100));
        light1.color = Color.HSVToRGB(evolutionColorTime / 2, saturation / 100, value / 100);
        light2.color = Color.HSVToRGB(evolutionColorTime / 2, saturation / 100, value / 100);
        light3.color = Color.HSVToRGB(evolutionColorTime / 2, saturation / 100, value / 100);
    }
}

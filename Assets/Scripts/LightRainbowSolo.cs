using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LightRainbowSolo : MonoBehaviour
{
    public Light light;
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

        if (evolutionColorTime >= 2f)
        {
            evolutionColorTime = 0;
        }

        light.color = Color.HSVToRGB(evolutionColorTime / 2, saturation / 100, value / 100);

    }
}

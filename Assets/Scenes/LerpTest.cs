using JetBrains.Annotations;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LerpTest : MonoBehaviour
{
    public GameObject endPos;
    public GameObject startPos;
    private float duration = 3f;
    private float elapsedTime;
    public float evolutionColorTime;
    public float m_HueStart;
    public float m_HueEnd;
    public float m_SaturationStart;
    public float m_SaturationEnd;
    public float m_ValueStart;
    public float m_ValueEnd;
    
    public Color startColor;
    public Color evolutiveColor;
    public Color endColor;

    public float evolutiveValue;
    public float startValue = 0f;
    public float endValue = 255f;

    public void Start()
    {
        startColor = Color.HSVToRGB(m_HueStart / 360, m_SaturationStart / 100, m_ValueStart / 100);
        endColor = Color.HSVToRGB(m_HueEnd / 360, m_SaturationEnd / 100, m_ValueEnd / 100);
    }

    private void Update()
    {
        elapsedTime += Time.deltaTime;
        evolutionColorTime += Time.deltaTime;
        float percentageComplete = elapsedTime / duration;

        if (evolutionColorTime >= 5f)
        {
            evolutionColorTime = 0f;
        }

        evolutiveColor = Color.HSVToRGB(evolutionColorTime / 5, m_SaturationStart / 100, m_ValueStart / 100);

        //startColor = Color.HSVToRGB(m_HueStart / 360, m_SaturationStart / 100, m_ValueStart / 100);
        //endColor = Color.HSVToRGB(m_HueEnd / 360, m_SaturationEnd / 100, m_ValueEnd / 100);

        //evolutiveColor = Color.Lerp(Color.HSVToRGB(m_HueStart / 360, m_SaturationStart / 100, m_ValueStart / 100), Color.HSVToRGB(m_HueEnd / 360, m_SaturationEnd / 100, m_ValueEnd / 100), percentageComplete);

        //evolutiveColor = Color.Lerp(startColor, endColor, percentageComplete);

        //transform.position = Vector3.Lerp(startPos.transform.position, endPos.transform.position, percentageComplete);
    }
}

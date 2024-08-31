using DG.Tweening;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class QuitMouseDetect : MonoBehaviour
{
    public bool Hovered;
    public bool stayHovered;
    public Light optionsLight1;
    public Light optionsLight2;
    public Light optionsLight3;
    public Color defaultColor;
    public Material emissiveDefault;
    //public Material emissiveRed;

    void Start()
    {
        Hovered = false;
        //emissiveDefault.color = emissiveDefault.color;
    }

    private void OnMouseEnter()
    {
        Hovered = true;
    }

    private void OnMouseExit()
    {
        Hovered = false;
        emissiveDefault.SetColor("_EmissionColor", Color.Lerp(Color.red, defaultColor, 1f));
    }

    void Update()
    {
        if (Hovered)
        {
            optionsLight1.DOColor(Color.red, 1);
            optionsLight2.DOColor(Color.red, 1);
            optionsLight3.DOColor(Color.red, 1);
            emissiveDefault.SetColor("_EmissionColor", Color.Lerp(defaultColor, Color.red, 1));
        }
        else
        {
            optionsLight1.DOColor(Color.white, 1);
            optionsLight2.DOColor(Color.white, 1);
            optionsLight3.DOColor(Color.white, 1);
        }

        if (stayHovered)
        {
            optionsLight1.DOColor(Color.red, 1);
            optionsLight2.DOColor(Color.red, 1);
            optionsLight3.DOColor(Color.red, 1);
            emissiveDefault.SetColor("_EmissionColor", Color.Lerp(defaultColor, Color.red, 1));
        }
        else
        {
            optionsLight1.DOColor(Color.white, 1);
            optionsLight2.DOColor(Color.white, 1);
            optionsLight3.DOColor(Color.white, 1);
            emissiveDefault.DOColor(Color.white, 1);
        }
    }
}

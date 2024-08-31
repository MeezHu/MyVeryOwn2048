using DG.Tweening;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OptionsMouseDetect : MonoBehaviour
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
        //defaultColor = new Color(255, 241, 158);
    }

    private void OnMouseEnter()
    {
        Hovered = true;
    }

    private void OnMouseExit()
    {
        Hovered = false;
        emissiveDefault.SetColor("_EmissionColor", Color.Lerp(Color.blue, defaultColor, 1f));
    }

    void Update()
    {
        if (Hovered)
        {
            optionsLight1.DOColor(Color.blue, 1);
            optionsLight2.DOColor(Color.blue, 1);
            optionsLight3.DOColor(Color.blue, 1);
            emissiveDefault.SetColor("_EmissionColor", Color.Lerp(defaultColor, Color.blue, 1));
        }
        else
        {
            optionsLight1.DOColor(Color.white, 1);
            optionsLight2.DOColor(Color.white, 1);
            optionsLight3.DOColor(Color.white, 1);
            emissiveDefault.DOColor(Color.white, 1);
        }

        if (stayHovered)
        {
            optionsLight1.DOColor(Color.blue, 1);
            optionsLight2.DOColor(Color.blue, 1);
            optionsLight3.DOColor(Color.blue, 1);
            emissiveDefault.SetColor("_EmissionColor", Color.Lerp(defaultColor, Color.blue, 1));
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

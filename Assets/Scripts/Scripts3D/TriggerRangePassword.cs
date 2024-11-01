using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Timeline;

public class TriggerRangePassword : MonoBehaviour
{
    public Typer typer;
    public TriggerPasswordSpawn triggerPasswordSpawn;
    public GameObject kOff;
    public GameObject kOn;


    public void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player" && triggerPasswordSpawn.canType)
        {
            kOff.SetActive(false);
            kOn.SetActive(true);
            typer.enabled = true;
        }
    }

    public void OnTriggerExit(Collider other)
    {
        kOn.SetActive(false);
        kOff.SetActive(true);
        typer.enabled = false;
    }
}

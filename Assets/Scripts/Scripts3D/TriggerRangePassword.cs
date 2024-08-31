using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriggerRangePassword : MonoBehaviour
{
    public Typer typer;
    public TriggerPasswordSpawn triggerPasswordSpawn;

    public void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player" && triggerPasswordSpawn.canType)
        {
            typer.enabled = true;
        }
    }

    public void OnTriggerExit(Collider other)
    {
        typer.enabled = false;
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorNoiseHardControl : MonoBehaviour
{
    public GameObject RandomDoorNoiseHard;
    public float randomWait;
    public bool canNoise = true;

    void Start()
    {
        StartCoroutine(CoroutineDoorNoiseHard());
    }

    IEnumerator CoroutineDoorNoiseHard()
    {
        if (canNoise)
        {
            randomWait = Random.Range(8, 15);
            yield return new WaitForSeconds(6);
            RandomDoorNoiseHard.SetActive(true);
            RandomDoorNoiseHard.SetActive(false);
            yield return new WaitForSeconds(randomWait);
            StartCoroutine(CoroutineDoorNoiseHard());
        }
    }
}

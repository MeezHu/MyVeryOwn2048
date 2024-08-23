using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorNoiseHardControl : MonoBehaviour
{
    public GameObject RandomDoorNoiseHard;
    public float randomWait;

    void Start()
    {
        StartCoroutine(CoroutineDoorNoiseHard());
    }

    IEnumerator CoroutineDoorNoiseHard()
    {
        randomWait = Random.Range(8, 15);
        yield return new WaitForSeconds(2);
        RandomDoorNoiseHard.SetActive(true);
        RandomDoorNoiseHard.SetActive(false);
        yield return new WaitForSeconds(randomWait);
        StartCoroutine(CoroutineDoorNoiseHard());
    }
}

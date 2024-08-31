using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorNoiseSoftControl : MonoBehaviour
{
    public GameObject RandomDoorNoiseSoft;
    public float randomWait;
    public bool canNoise = true;

    void Start()
    {
        StartCoroutine(CoroutineDoorNoiseSoft());
    }

    IEnumerator CoroutineDoorNoiseSoft()
    {
        if (canNoise)
        {
            randomWait = Random.Range(8, 25);
            yield return new WaitForSeconds(3);
            RandomDoorNoiseSoft.SetActive(true);
            RandomDoorNoiseSoft.SetActive(false);
            yield return new WaitForSeconds(randomWait);
            StartCoroutine(CoroutineDoorNoiseSoft());
        }
    }
}

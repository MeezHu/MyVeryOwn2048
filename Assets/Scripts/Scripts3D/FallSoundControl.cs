using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FallSoundControl : MonoBehaviour
{
    public GameObject WindFallSound;
    public GameObject FallSound1;
    public GameObject FallSound2;
    public GameObject FallSound3;
    public GameObject FallSound4;

    void Start()
    {
        StartCoroutine(CoroutineFallSound());
    }

    IEnumerator CoroutineFallSound()
    {
        yield return new WaitForSeconds(1);
        WindFallSound.SetActive(true);
        yield return new WaitForSeconds(5.3f);
        FallSound1.SetActive(true);
        FallSound2.SetActive(true);
        FallSound3.SetActive(true);
        FallSound4.SetActive(true);
    }
}

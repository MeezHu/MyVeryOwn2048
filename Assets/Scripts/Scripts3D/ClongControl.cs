using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ClongControl : MonoBehaviour
{
    public GameObject[] clongs;
    public bool canClong = true;

    private void Start()
    {
        StartCoroutine(ActiveRandomClong());
    }

    IEnumerator ActiveRandomClong()
    {
        if (canClong)
        {
            int randomClong = Random.Range(0, clongs.Length);
            float repeatTime = Random.Range(25, 60);

            clongs[randomClong].SetActive(true);
            yield return new WaitForSeconds(0.1f);
            clongs[randomClong].SetActive(false);

            yield return new WaitForSeconds(repeatTime);
            StartCoroutine(ActiveRandomClong());
        }
    }

    void Update()
    {
        
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class TriggerEndScene : MonoBehaviour
{
    public GameObject endCanvas;
    public GameObject lightsOnSound;

    public void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {
            StartCoroutine(CoroutineEnd());
        }
    }

    IEnumerator CoroutineEnd()
    {
        endCanvas.SetActive(true);
        lightsOnSound.SetActive(false);
        lightsOnSound.SetActive(true);
        yield return new WaitForSeconds(2);
        SceneManager.LoadScene(3);
    }
}

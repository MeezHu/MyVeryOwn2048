using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriggerSecretEnding : MonoBehaviour
{
    public void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {
            Debug.Log("SECRET ENDING!");
            gameObject.SetActive(false);
        }
    }
}

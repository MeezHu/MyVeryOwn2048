using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriggerPasswordSpawn : MonoBehaviour
{
    public GameObject password;
    public GameObject landLight;
    public GameObject landLightSound;
    public GameObject spotPath;
    public SecretManager secretManager;
    public bool canType;

    public void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {
            spotPath.SetActive(true);
            password.SetActive(true);
            //PlayerPrefs.SetInt("rememberPassword", 1);
            PlayerPrefs.SetInt("knowspassword", 1);
            gameObject.SetActive(false);
            //canType = true;
            landLight.SetActive(true);
            landLightSound.SetActive(true);
        }
    }
}

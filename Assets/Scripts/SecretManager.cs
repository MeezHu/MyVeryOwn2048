using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SecretManager : MonoBehaviour
{
    public GameObject canvasYouDont;
    public GameObject canvasYouCan;
    public GameObject canvasPasswordEntered;
    public GameObject boxInCompRange;

    void Start()
    {
        PlayerPrefs.SetInt("knowspassword", 0);
    }

    void Update()
    {
        if (PlayerPrefs.GetInt("knowspassword") == 0)
        {
            canvasYouDont.SetActive(true);
            canvasYouCan.SetActive(false);
        }
        if (PlayerPrefs.GetInt("knowspassword") == 1)
        {
            canvasYouDont.SetActive(false);
            canvasYouCan.SetActive(true);
        }

        if (Input.GetKeyDown(KeyCode.Space))
        {
            PlayerPrefs.SetInt("knowspassword", 1);
        }

        Debug.Log(PlayerPrefs.GetInt("knowspassword"));
    }
}

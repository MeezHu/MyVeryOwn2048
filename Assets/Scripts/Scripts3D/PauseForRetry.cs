using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PauseForRetry : MonoBehaviour
{
    public PauseMenuController pauseMenuController;
    public GameObject ambiance1;

    void Start()
    {
        ambiance1.SetActive(true);

        pauseMenuController = GetComponent<PauseMenuController>();

        pauseMenuController.canPause = true;
    }
    void Update()
    {
        
    }
}

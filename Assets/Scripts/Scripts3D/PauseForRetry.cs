using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PauseForRetry : MonoBehaviour
{
    public PauseMenuController pauseMenuController;

    void Start()
    {
        pauseMenuController = GetComponent<PauseMenuController>();

        pauseMenuController.canPause = true;
    }
    void Update()
    {
        
    }
}

using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PauseMenuController : MonoBehaviour
{
    public PlayerMovement playerMovement;
    public MouseLook mouseLook;
    public VolumeSliderController volumeSliderController;
    public GameObject pauseMenuCanvas;
    public bool isPaused;

    public int MainMenuScene;
    public int RetryScene;

    public void ReturnToMainMenu()
    {
        Debug.Log("ReturnToMainMenu");
        SceneManager.LoadScene(MainMenuScene);
    }

    public void ExitGame()
    {
        Debug.Log("ExitGame");
        Application.Quit();
    }
    
    public void Retry()
    {
        Debug.Log("Retry");
        SceneManager.LoadScene(RetryScene);
    }

    IEnumerator CoroutinePauseOn()
    {
        yield return new WaitForSeconds(0.05f);
        volumeSliderController.phantomVolume.Select();
        playerMovement.enabled = false;
        mouseLook.enabled = false;
        Cursor.lockState = CursorLockMode.Locked;
        isPaused = true;
        pauseMenuCanvas.SetActive(true);
    }

    IEnumerator CoroutinePauseOff()
    {
        yield return new WaitForSeconds(0.05f);
        playerMovement.enabled = true;
        mouseLook.enabled = true;
        Cursor.lockState = CursorLockMode.Locked;
        isPaused = false;
        pauseMenuCanvas.SetActive(false);
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape) && isPaused == false)
        {
            StartCoroutine(CoroutinePauseOn());
        }

        if (Input.GetKeyDown(KeyCode.Escape) && isPaused == true)
        {
            StartCoroutine(CoroutinePauseOff());
        }
    }
}

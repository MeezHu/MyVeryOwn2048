using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PauseMenuController : MonoBehaviour
{
    public PlayerMovement playerMovement;
    public RememberSensitivity rememberSensitivity;
    public MouseLook mouseLook;
    public VolumeSliderController volumeSliderController;
    public HeadBobController headBobController;
    public StepSoundControl stepSoundControl;
    public ControlGears controlGears;
    public GameObject pauseMenuCanvas;
    public bool canPause;
    public bool isPaused;

    public int MainMenuScene;
    public int RetryScene;

    private void Start()
    {
        Invoke("CanPause", 20);
    }

    public void ReturnToMainMenu()
    {
        Debug.Log("ReturnToMainMenu");
        SceneManager.LoadScene(MainMenuScene);
    }

    public void CanPause()
    {
        canPause = true;
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
        if (Input.GetKeyDown(KeyCode.Escape) && isPaused == false && canPause)
        {
            rememberSensitivity.lockSliderSensi = false;
            StartCoroutine(CoroutinePauseOn());
        }

        if (Input.GetKeyDown(KeyCode.Escape) && isPaused == true)
        {
            rememberSensitivity.lockSliderSensi = true;
            StartCoroutine(CoroutinePauseOff());
        }
        
        if (Input.GetKeyDown(KeyCode.Escape) && isPaused == false && canPause && StateManager.Instance.canPovFps)
        {
            FpsState.isInBoard = !FpsState.isInBoard;
            BoardState.canMove = !BoardState.canMove;

            StartCoroutine(StateManager.Instance.CoroutineFpsView());
            headBobController.enabled = true;
            stepSoundControl.enabled = true;
            controlGears.canRotateGears = false;
        }
    }
}

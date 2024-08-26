using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MouseLook : MonoBehaviour
{

    public float mouseSensitivity = 1000f;

    public Transform playerBody;

    float xRotation = 0f;

    public bool canMoveMouse;

    // Start is called before the first frame update
    void Start()
    {
        Cursor.lockState = CursorLockMode.Locked;
        canMoveMouse = true;
    }

    // Update is called once per frame
    void Update()
    {
        if (canMoveMouse)
        {
            try
            {
                FpsState testState = (FpsState)StateManager.Instance.currentState;

                float mouseX = Input.GetAxis("Mouse X") * mouseSensitivity * Time.deltaTime;
                float mouseY = Input.GetAxis("Mouse Y") * mouseSensitivity * Time.deltaTime;

                xRotation -= mouseY;
                xRotation = Mathf.Clamp(xRotation, -60f, 60f);

                transform.localRotation = Quaternion.Euler(xRotation, 0f, 0f);
                playerBody.Rotate(Vector3.up * mouseX);
                
            }
            catch { }
        }
        
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MouseForRetry : MonoBehaviour
{
    private MouseLook mouseLook;

    void Start()
    {
        mouseLook = GetComponent<MouseLook>();
        Invoke("ActivateMouseLook", 3.5f);
    }

    private void ActivateMouseLook()
    {
        if (mouseLook != null)
        {
            mouseLook.enabled = true;
        }
    }

    void Update()
    {
        
    }
}

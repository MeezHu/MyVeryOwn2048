using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LightsFeedback : MonoBehaviour
{
    public FlickerControl[] flickerControlList;
    public bool canStartFlicker = true;

    [ContextMenu("StartFlickeringLight()")]
    public void StartFlickeringLight()
    {
        Debug.Log("StartFlickeringLight");
        foreach (FlickerControl flicker in flickerControlList)
        {
            flicker.enabled = true;
        }

        //if (canStartFlicker)
        //{
        //    canStartFlicker = false;
        //    Debug.Log("StartFlickeringLight");
        //    foreach(FlickerControl flicker in flickerControlList)
        //    {
        //        flicker.enabled = true;
        //    }
        //}
    }

    void Start()
    {
        
    }

    void Update()
    {
        
    }
}

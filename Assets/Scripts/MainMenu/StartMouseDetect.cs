using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StartMouseDetect : MonoBehaviour
{
    public bool Hovered;
    public HardFlickerControl HardFlickerControl1;
    public HardFlickerControl HardFlickerControl2;
    public Vector3 startPos;
    public Vector3 endPos;

    void Start()
    {
        HardFlickerControl1.enabled = false;
        HardFlickerControl2.enabled = false;

        startPos = transform.position;
    }

    public void GoAway()
    {
        gameObject.transform.localPosition = Vector3.Lerp(startPos, endPos, 1);
    }

    public void GoBack()
    {
        gameObject.transform.localPosition = Vector3.Lerp(endPos, startPos, 1);
    }

    private void OnMouseEnter()
    {
        Hovered = true;
    }

    private void OnMouseExit()
    {
        Hovered = false;
    }

    void Update()
    {
        if (Hovered)
        {
            HardFlickerControl1.enabled = true;
            HardFlickerControl2 .enabled = true;
        }
        if (Hovered == false)
        {
            HardFlickerControl1.enabled = false;
            HardFlickerControl2.enabled = false;
        }
    }
}

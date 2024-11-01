using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class PlayerHeightController : MonoBehaviour
{
    public GameObject playerBody;
    public bool inEndZone;
    public bool canChange;

    public Vector3 currentPos;
    public Vector3 correctPos;

    void Start()
    {
        correctPos = new Vector3(0, 0.15f, 0);
    }

    void Update()
    {
        currentPos = playerBody.transform.position;

        if (inEndZone && canChange)
        {
            canChange = false;
            playerBody.transform.position = currentPos + correctPos;
        }

        if (inEndZone == false && canChange == false)
        {
            canChange = true;
            playerBody.transform.position = currentPos - correctPos;
        }
    }
}

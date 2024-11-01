using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriggerPovHeightChange : MonoBehaviour
{
    public PlayerHeightController playerHeightController;

    public void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {
            if (playerHeightController.inEndZone == false)
            {
                playerHeightController.inEndZone = true;
            }
            else
            {
                playerHeightController.inEndZone = false;
            }
        }
    }
}

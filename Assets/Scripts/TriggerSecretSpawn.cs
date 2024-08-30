using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriggerSecretSpawn : MonoBehaviour
{
    public Animator secretAnimator;
    public bool canSecret;

    public void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {
            canSecret = true;
        }
    }

    public void OnTriggerExit(Collider other)
    {
        if (other.tag == "Player")
        {
            canSecret = false;
        }
    }

    private void Update()
    {
        
    }

}

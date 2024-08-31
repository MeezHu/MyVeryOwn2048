using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriggerSecretSpawn : MonoBehaviour
{
    public Animator secretAnimator;
    public GameObject boxPasswordRange;
    public GameObject secretComeSound;
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
        if (Input.GetKeyDown(KeyCode.E) && canSecret)
        {
            secretAnimator.SetTrigger("Come");
            secretComeSound.SetActive(true);
            gameObject.SetActive(false);
        }
    }

}

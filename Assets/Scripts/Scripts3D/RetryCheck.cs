using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RetryCheck : MonoBehaviour
{
    public bool canRetry;
    public GameObject noRetryButton;
    public GameObject noRetryText;

    void Update()
    {
        //if (canRetry)
        //{
        //    noRetryButton.SetActive(false);
        //    noRetryText.SetActive(false);
        //    yesRetryButton.SetActive(true);
        //    yesRetryText.SetActive(true);
        //}

        if (canRetry == false)
        {
            noRetryText.SetActive(true);
        }
        else
        {
            noRetryText.SetActive(false);
        }
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WhiteFadeRetryController : MonoBehaviour
{
    public Animator whiteFadeAnimator;
    public GameObject preFade;

    void Start()
    {
        whiteFadeAnimator = GetComponent<Animator>();

        Invoke("PreFadeDeactivate", 1);
        WhiteFadeOut();
    }

    public void WhiteFadeOut()
    {
        whiteFadeAnimator.SetTrigger("FadeOut");
    }

    public void PreFadeDeactivate()
    {
        preFade.SetActive(false);
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WhiteFadeController : MonoBehaviour
{
    public Animator whiteFadeAnimator;
    public GameObject preFade;

    void Start()
    {
        whiteFadeAnimator = GetComponent<Animator>();
    }

    public void WhiteFadeIn()
    {
        whiteFadeAnimator.SetTrigger("FadeIn");
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.Windows;

public class CreditsManager : MonoBehaviour
{
    public GameObject credit1;
    public GameObject credit2;
    public GameObject credit3;
    public GameObject credit4;
    public GameObject pressESC;
    public bool canQuit;
    public Animator creditsFadeAnimator;

    void Start()
    {
        Invoke("FadeOut", 2);
        Invoke("CreditsLaunch", 20);
    }

    public void FadeOut()
    {
        creditsFadeAnimator.SetTrigger("fadeOUT");
    }

    public void CreditsLaunch()
    {
        StartCoroutine(CoroutineCredits());
    }

    IEnumerator CoroutineCredits()
    {
        credit1.SetActive(true);

        yield return new WaitForSeconds(5);
        credit2.SetActive(true);

        yield return new WaitForSeconds(15);
        credit3.SetActive(true);

        yield return new WaitForSeconds(25);
        credit4.SetActive(true);
    }

    IEnumerator CoroutineESC()
    {
        yield return new WaitForSeconds(.05f);
        canQuit = true;

        yield return new WaitForSeconds(3);
        canQuit = false;
    }

    void Update()
    {
        if (UnityEngine.Input.GetKeyDown(KeyCode.Escape))
        {
            StartCoroutine(CoroutineESC());

            if (canQuit)
            {
                SceneManager.LoadScene(0);
            }
        }

        

        if (canQuit)
        {
            pressESC.SetActive(true);
        }
        if (canQuit == false)
        {
            pressESC.SetActive(false);
        }
    }
}

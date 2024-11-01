using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GridController : MonoBehaviour
{
    public Animator gridAnimator;
    public GameObject gridSound;

    void Start()
    {
        gridAnimator = GetComponent<Animator>();

        Invoke("OpeningGrid", 30);
    }

    public void OpeningGrid()
    {
        gridAnimator.SetTrigger("Open");
        gridSound.SetActive(true);
        gridSound.SetActive(false);
    }
}

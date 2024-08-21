using JetBrains.Annotations;
using System;
using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;
using UnityEngine.VFX;

public class ControlGears : MonoBehaviour
{
    public Animator gearAnimator;
    public bool canRotateGears;

    public int topVfxIndex;
    public int bottomVfxIndex;
    public int leftVfxIndex;
    public int rightVfxIndex;

    public GameObject left0;
    public GameObject left1;
    public GameObject left2;
    public GameObject left3;
    public GameObject left4;
    public GameObject left5;
    public GameObject left6;
    public GameObject left7;

    public GameObject right0;
    public GameObject right1;
    public GameObject right2;
    public GameObject right3;
    public GameObject right4;

    public GameObject top0;
    public GameObject top1;
    public GameObject top2;
    public GameObject top3;

    public GameObject bottom0;
    public GameObject bottom1;
    public GameObject bottom2;
    public GameObject bottom3;
    public GameObject bottom4;

    public GameObject gearSpinLeft;
    public GameObject gearSpinUp;
    public GameObject gearSpinRight;
    public GameObject gearSpinDown;
    public GameObject steamBlastLeft;
    public GameObject steamBlastUp;
    public GameObject steamBlastRight;
    public GameObject steamBlastDown;

    private void Start()
    {
        canRotateGears = false;
    }

    public void PressedInput()
    {
        if (Input.GetKeyDown(KeyCode.LeftArrow))
        {
            rightVfxIndex = UnityEngine.Random.Range(0, 4);
            //Debug.Log(leftVfxIndex);
            gearAnimator.Play("spinLeft", 0, 0);
            StartCoroutine(GearSpinLeft());
            // gearAnimator.SetTrigger("spinLeft");

            if (rightVfxIndex == 0)
            {
                StartCoroutine(CoroutineRight0());
            }

            if (rightVfxIndex == 1)
            {
                StartCoroutine(CoroutineRight1());
            }

            if (rightVfxIndex == 2)
            {
                StartCoroutine(CoroutineRight2());
            }

            if (rightVfxIndex == 3)
            {
                StartCoroutine(CoroutineRight3());
            }

            if (rightVfxIndex == 4)
            {
                StartCoroutine(CoroutineRight4());
            }
        }
        
        if (Input.GetKeyDown(KeyCode.UpArrow))
        {
            bottomVfxIndex = UnityEngine.Random.Range(0, 4);
            gearAnimator.Play("spinUp", 0, 0);
            StartCoroutine(GearSpinUp());
            //gearAnimator.SetTrigger("spinUp");

            if (bottomVfxIndex == 0)
            {
                StartCoroutine(CoroutineBottom0());
            }

            if (bottomVfxIndex == 1)
            {
                StartCoroutine(CoroutineBottom1());
            }

            if (bottomVfxIndex == 2)
            {
                StartCoroutine(CoroutineBottom2());
            }

            if (bottomVfxIndex == 3)
            {
                StartCoroutine(CoroutineBottom3());
            }

            if (bottomVfxIndex == 4)
            {
                StartCoroutine(CoroutineBottom4());
            }
        }
        
        if (Input.GetKeyDown(KeyCode.RightArrow))
        {
            leftVfxIndex = UnityEngine.Random.Range(0, 7);
            gearAnimator.Play("spinRight", 0, 0);
            StartCoroutine(GearSpinRight());
            //gearAnimator.SetTrigger("spinRight");

            if (leftVfxIndex == 0)
            {
                StartCoroutine(CoroutineLeft0());
            }

            if (leftVfxIndex == 1)
            {
                StartCoroutine(CoroutineLeft1());
            }

            if (leftVfxIndex == 2)
            {
                StartCoroutine(CoroutineLeft2());
            }

            if (leftVfxIndex == 3)
            {
                StartCoroutine(CoroutineLeft3());
            }

            if (leftVfxIndex == 4)
            {
                StartCoroutine(CoroutineLeft4());
            }

            if (leftVfxIndex == 5)
            {
                StartCoroutine(CoroutineLeft5());
            }

            if (leftVfxIndex == 6)
            {
                StartCoroutine(CoroutineLeft6());
            }

            if (leftVfxIndex == 7)
            {
                StartCoroutine(CoroutineLeft7());
            }
        }
        
        if (Input.GetKeyDown(KeyCode.DownArrow))
        {
            topVfxIndex = UnityEngine.Random.Range(0, 3);
            gearAnimator.Play("spinDown", 0, 0);
            StartCoroutine(GearSpinDown());
            //gearAnimator.SetTrigger("spinDown");

            if (topVfxIndex == 0)
            {
                StartCoroutine(CoroutineTop0());
            }

            if (topVfxIndex == 1)
            {
                StartCoroutine(CoroutineTop1());
            }

            if (topVfxIndex == 2)
            {
                StartCoroutine(CoroutineTop2());
            }

            if (topVfxIndex == 3)
            {
                StartCoroutine(CoroutineTop3());
            }
        }

        
    }

    public IEnumerator GearSpinLeft()
    {
        gearSpinLeft.SetActive(true);
        steamBlastLeft.SetActive(true);
        gearSpinLeft.SetActive(false);
        steamBlastLeft.SetActive(false);
        yield return null;
    }

    public IEnumerator GearSpinUp()
    {
        gearSpinUp.SetActive(true);
        steamBlastUp.SetActive(true);
        gearSpinUp.SetActive(false);
        steamBlastUp.SetActive(false);
        yield return null;
    }

    public IEnumerator GearSpinRight()
    {
        gearSpinRight.SetActive(true);
        steamBlastRight.SetActive(true);
        gearSpinRight.SetActive(false);
        steamBlastRight.SetActive(false);
        yield return null;
    }

    public IEnumerator GearSpinDown()
    {
        gearSpinDown.SetActive(true);
        steamBlastDown.SetActive(true);
        gearSpinDown.SetActive(false);
        steamBlastDown.SetActive(false);
        yield return null;
    }

    public IEnumerator CoroutineLeft0()
    {
        left0.SetActive(true);
        yield return new WaitForSeconds(0.3f);
        left0.SetActive(false);
    }

    public IEnumerator CoroutineLeft1()
    {
        left1.SetActive(true);
        yield return new WaitForSeconds(0.3f);
        left1.SetActive(false);
    }

    public IEnumerator CoroutineLeft2()
    {
        left2.SetActive(true);
        yield return new WaitForSeconds(0.3f);
        left2.SetActive(false);
    }

    public IEnumerator CoroutineLeft3()
    {
        left3.SetActive(true);
        yield return new WaitForSeconds(0.3f);
        left3.SetActive(false);
    }

    public IEnumerator CoroutineLeft4()
    {
        left4.SetActive(true);
        yield return new WaitForSeconds(0.3f);
        left4.SetActive(false);
    }

    public IEnumerator CoroutineLeft5()
    {
        left5.SetActive(true);
        yield return new WaitForSeconds(0.3f);
        left5.SetActive(false);
    }

    public IEnumerator CoroutineLeft6()
    {
        left6.SetActive(true);
        yield return new WaitForSeconds(0.3f);
        left6.SetActive(false);
    }

    public IEnumerator CoroutineLeft7()
    {
        left7.SetActive(true);
        yield return new WaitForSeconds(0.3f);
        left7.SetActive(false);
    }

    public IEnumerator CoroutineRight0()
    {
        right0.SetActive(true);
        yield return new WaitForSeconds(0.3f);
        right0.SetActive(false);
    }

    public IEnumerator CoroutineRight1()
    {
        right1.SetActive(true);
        yield return new WaitForSeconds(0.3f);
        right1.SetActive(false);
    }

    public IEnumerator CoroutineRight2()
    {
        right2.SetActive(true);
        yield return new WaitForSeconds(0.3f);
        right2.SetActive(false);
    }

    public IEnumerator CoroutineRight3()
    {
        right3.SetActive(true);
        yield return new WaitForSeconds(0.3f);
        right3.SetActive(false);
    }

    public IEnumerator CoroutineRight4()
    {
        right4.SetActive(true);
        yield return new WaitForSeconds(0.3f);
        right4.SetActive(false);
    }

    public IEnumerator CoroutineTop0()
    {
        top0.SetActive(true);
        yield return new WaitForSeconds(0.3f);
        top0.SetActive(false);
    }

    public IEnumerator CoroutineTop1()
    {
        top1.SetActive(true);
        yield return new WaitForSeconds(0.3f);
        top1.SetActive(false);
    }

    public IEnumerator CoroutineTop2()
    {
        top2.SetActive(true);
        yield return new WaitForSeconds(0.3f);
        top2.SetActive(false);
    }

    public IEnumerator CoroutineTop3()
    {
        top3.SetActive(true);
        yield return new WaitForSeconds(0.3f);
        top3.SetActive(false);
    }

    public IEnumerator CoroutineBottom0()
    {
        bottom0.SetActive(true);
        yield return new WaitForSeconds(0.3f);
        bottom0.SetActive(false);
    }

    public IEnumerator CoroutineBottom1()
    {
        bottom1.SetActive(true);
        yield return new WaitForSeconds(0.3f);
        bottom1.SetActive(false);
    }

    public IEnumerator CoroutineBottom2()
    {
        bottom2.SetActive(true);
        yield return new WaitForSeconds(0.3f);
        bottom2.SetActive(false);
    }

    public IEnumerator CoroutineBottom3()
    {
        bottom3.SetActive(true);
        yield return new WaitForSeconds(0.3f);
        bottom3.SetActive(false);
    }

    public IEnumerator CoroutineBottom4()
    {
        bottom4.SetActive(true);
        yield return new WaitForSeconds(0.3f);
        bottom4.SetActive(false);
    }

    private void Update()
    {
        if (canRotateGears)
        {
            PressedInput();
        }
    }
}

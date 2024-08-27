using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GetUpSoundsController : MonoBehaviour
{
    public GameObject getUp1;
    public GameObject getUp2;
    public GameObject getUp3;

    public void GetUp1()
    {
        getUp1.SetActive(true);
    }

    public void GetUp2()
    {
        getUp2.SetActive(true);
    }

    public void GetUp3()
    {
        getUp3.SetActive(true);
    }

}

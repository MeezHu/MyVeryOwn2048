using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriggerLights : MonoBehaviour
{
    public GameObject Landlight1;
    public GameObject Landlight2;
    public GameObject Landlight3;
    public GameObject Landlight4;
    public GameObject Landlight5;
    public GameObject Landlight6;
    public GameObject Landlight7;
    public GameObject Landlight8;
    public GameObject reflecProb;
    public GameObject LightsOn;


    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {
            Landlight1.SetActive(false);
            Landlight2.SetActive(false);
            Landlight3.SetActive(false);
            Landlight4.SetActive(false);

            Landlight5.SetActive(true);
            Landlight6.SetActive(true);
            Landlight7.SetActive(true);
            Landlight8.SetActive(true);
            reflecProb.SetActive(true);
            LightsOn.SetActive(true);

            gameObject.SetActive(false);
        }
    }
}

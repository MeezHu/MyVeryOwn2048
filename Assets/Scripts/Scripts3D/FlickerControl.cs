using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class FlickerControl : MonoBehaviour
{
    public bool isFlickering = false;
    public float timeDelay;
    public Component[] lights;
    //public Material material;
    public Renderer renderer;

    private void Start()
    {
        lights = GetComponentsInChildren<Light>();
        renderer = GetComponentInChildren<Renderer>();
    }


    void Update()
    {
        if (isFlickering == false)
        {
            StartCoroutine(CoroutineFlickeringLight());
        }
    }

    IEnumerator CoroutineFlickeringLight()
    {
        isFlickering = true;
        foreach (Light light in lights)
        {
            light.enabled = false;
        }
        renderer.material.DisableKeyword("_EMISSION");
        //this.gameObject.GetComponentsInChildren<Light>(). = false;
        timeDelay = Random.Range(0.01f, 0.1f);
        yield return new WaitForSeconds(timeDelay);
        foreach (Light light in lights)
        {
            light.enabled = true;
        }
        renderer.material.EnableKeyword("_EMISSION");
        //this.gameObject.GetComponentInChildren<Light>().enabled = true;
        timeDelay = Random.Range(0.01f, 5f);
        yield return new WaitForSeconds(timeDelay);
        isFlickering = false;
    }
}

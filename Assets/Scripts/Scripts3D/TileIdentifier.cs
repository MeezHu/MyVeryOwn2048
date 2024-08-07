using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TileIdentifier : MonoBehaviour
{
    private Renderer renderer;

    public For3DTile for3DTile;

    private void Awake()
    {
        //renderer = GetComponent<Renderer>();
        for3DTile = GetComponent<For3DTile>();
    }

    // Start is called before the first frame update
    void Start()
    {
        //Debug.Log("mon matériau est " +  renderer.material.name);
    }

    // Update is called once per frame
    void Update()
    {
        //Debug.Log("mon matériau est " + renderer.material.name);
    }

    public void CheckIdentity()
    {
        switch (for3DTile.matName)
        {
            case "M_2":
                Debug.Log("Tuile = " + for3DTile.matName + " appeared in " + gameObject.transform.position);
                break;
            case "M_4":
                Debug.Log("Tuile = " + for3DTile.matName + " appeared in " + gameObject.transform.position);
                break;
            case "M_8":
                Debug.Log("Tuile = " + for3DTile.matName + " appeared in " + gameObject.transform.position);
                break;
            case "M_16":
                Debug.Log("Tuile = " + for3DTile.matName + " appeared in " + gameObject.transform.position);
                break;
            case "M_32":
                Debug.Log("Tuile = " + for3DTile.matName + " appeared in " + gameObject.transform.position);
                break;
            case "M_64":
                Debug.Log("Tuile = " + for3DTile.matName + " appeared in " + gameObject.transform.position);
                break;
            case "M_128":
                Debug.Log("Tuile = " + for3DTile.matName + " appeared in " + gameObject.transform.position);
                break;
            case "M_256":
                Debug.Log("Tuile = " + for3DTile.matName + " appeared in " + gameObject.transform.position);
                break;
            case "M_512":
                Debug.Log("Tuile = " + for3DTile.matName + " appeared in " + gameObject.transform.position);
                break;
            case "M_1024":
                Debug.Log("Tuile = " + for3DTile.matName + " appeared in " + gameObject.transform.position);
                break;
            case "M_2048":
                Debug.Log("Tuile = " + for3DTile.matName + " appeared in " + gameObject.transform.position);
                break;


        }



        //if (for3DTile.matName == "M_2")
        //{
        //    Debug.Log("Tuile = " + for3DTile.matName + " appeared in " + gameObject.transform.position);
        //}
    }
}

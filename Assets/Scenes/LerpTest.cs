using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LerpTest : MonoBehaviour
{
    public GameObject volumeBar;
    public GameObject startPosVolumeObject;
    public GameObject endPosVolumeObject;

    public Vector3 start;
    public Vector3 end;
    public float volumeLerpValue;

    void Start()
    {
        start = new Vector3(0,0,0);
        end = new Vector3 (0,10,0);
    }

    void Update()
    {
        volumeBar.transform.position = Vector3.Lerp(start, end, volumeLerpValue);
    }
}

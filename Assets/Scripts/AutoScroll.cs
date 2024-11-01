using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AutoScroll : MonoBehaviour
{
    public Vector3 startPos;
    public Vector3 moveValue;

    void Start()
    {
        startPos = transform.position;
        moveValue = new Vector3(0, 1, 0);
    }

    void Update()
    {
        transform.position = startPos + moveValue;
        moveValue.y += 70f * Time.deltaTime;
    }
}

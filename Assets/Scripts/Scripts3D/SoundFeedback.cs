using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//Script des feedbacks sons
//En communication avec TileIdentifier

public class SoundFeedback : MonoBehaviour
{
    public TileIdentifier tileIdentifier;

    private void Awake()
    {
        tileIdentifier = GetComponent<TileIdentifier>();
    }

    void Start()
    {

    }

    public void SoundTest()
    {
        Debug.Log("Son incroyable joué");
    }

    void Update()
    {

    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//Script des feedbacks Animation
//En communication avec TileIdentifier

public class AnimationFeedback : MonoBehaviour
{
    public TileIdentifier tileIdentifier;

    private void Awake()
    {
        tileIdentifier = GetComponent<TileIdentifier>();
    }

    void Start()
    {

    }


    //faudra des s�curit� car les animations se joueront qu'une fois
    public void AnimationTest()
    {
        Debug.Log("Animation fabuleuse enclench�e");
    }

    void Update()
    {

    }
}

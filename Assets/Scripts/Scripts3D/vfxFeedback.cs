using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//Script des feedbacks vfx
//En communication avec TileIdentifier

public class vfxFeedback : MonoBehaviour
{
    public TileIdentifier tileIdentifier;

    private void Awake()
    {
        tileIdentifier = GetComponent<TileIdentifier>();
    }

    void Start()
    {
        
    }

    public void VfxTest()
    {
        Debug.Log("Vfx magnifique enclenché en " + tileIdentifier.gameObject.transform.position);
    }

    void Update()
    {
        
    }
}

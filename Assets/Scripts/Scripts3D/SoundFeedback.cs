using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//Script des feedbacks sons
//En communication avec TileIdentifier

public class SoundFeedback : MonoBehaviour
{
    public TileIdentifier tileIdentifier;

    public GameObject RandomSteamBlastSpecial;

    public GameObject StepSound;

    private void Awake()
    {
        tileIdentifier = GetComponent<TileIdentifier>();
    }

    void Start()
    {

    }

    public void SfxSpecialFusion()
    {
        Instantiate(RandomSteamBlastSpecial, tileIdentifier.gameObject.transform.position, gameObject.transform.rotation);
        //RandomSteamBlastSpecial.SetActive(true);
        //RandomSteamBlastSpecial.SetActive(false);
    }

    public void SoundTest()
    {
        Debug.Log("Son incroyable joué");
    }

    void Update()
    {
        
    }
}

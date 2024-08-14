using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//Script des feedbacks vfx
//En communication avec TileIdentifier

public class vfxFeedback : MonoBehaviour
{
    public TileIdentifier tileIdentifier;
    //public GameObject[] flickerControlList;

    public GameObject vfx_fusionDefault;
    public GameObject vfx_fusionSpecial;
    public GameObject vfx_fusion16;
    public GameObject vfx_fusion64;
    public GameObject vfx_fusion256;
    public GameObject vfx_fusion512;
    public GameObject vfx_fusion1024;
    public GameObject vfx_fusion2048;
    public GameObject OrientationTemoin;

    //public bool can16;
    //public bool can64;
    //public bool can256;
    //public bool can512;
    //public bool can1024;
    //public bool can2048;

    public Vector3 correcPos;
    public Quaternion vfx_fusionDefaultRotation;

    private void Awake()
    {
        tileIdentifier = GetComponent<TileIdentifier>();
        correcPos = new Vector3(0.05f, 0.05f, 0);
    }

    void Start()
    {
        //vfx_fusionDefaultRotation = new Quaternion(20, 120, 120 ,0 );
        vfx_fusionDefaultRotation = OrientationTemoin.transform.rotation;
        //can16 = true;
        //can64 = true;
        //can256 = true;
        //can512 = true;
        //can1024 = true;
        //can2048 = true;

    }

    

    public void VfxDefaultFusion()
    {

        //Debug.Log("Vfx magnifique enclenché en " + tileIdentifier.gameObject.transform.position);
        Instantiate(vfx_fusionDefault, tileIdentifier.gameObject.transform.position + correcPos, vfx_fusionDefaultRotation);
    }

    public void VfxSpecialFusion()
    {

        //Debug.Log("Vfx magnifique enclenché en " + tileIdentifier.gameObject.transform.position);
        Instantiate(vfx_fusionSpecial, tileIdentifier.gameObject.transform.position + correcPos, vfx_fusionDefaultRotation);
    }

    public void Vfx16Fusion()
    {

        //if (can16)
        //{
        //    Instantiate(vfx_fusion16, tileIdentifier.gameObject.transform.position + correcPos, vfx_fusionDefaultRotation);
        //    can16 = false;
        //}
        //else
        //{
        //    Instantiate(vfx_fusionDefault, tileIdentifier.gameObject.transform.position + correcPos, vfx_fusionDefaultRotation);
        //}

        Instantiate(vfx_fusion16, tileIdentifier.gameObject.transform.position + correcPos, vfx_fusionDefaultRotation);
        //Debug.Log("Vfx magnifique enclenché en " + tileIdentifier.gameObject.transform.position);
    }

    public void Vfx64Fusion()
    {
        //if (can64)
        //{
        //    Instantiate(vfx_fusion64, tileIdentifier.gameObject.transform.position + correcPos, vfx_fusionDefaultRotation);
        //    can64 = false;
        //}
        //else
        //{
        //    Instantiate(vfx_fusionDefault, tileIdentifier.gameObject.transform.position + correcPos, vfx_fusionDefaultRotation);
        //}

        Instantiate(vfx_fusion64, tileIdentifier.gameObject.transform.position + correcPos, vfx_fusionDefaultRotation);
        //Debug.Log("Vfx magnifique enclenché en " + tileIdentifier.gameObject.transform.position);
    }

    public void Vfx256Fusion()
    {

        //Debug.Log("Vfx magnifique enclenché en " + tileIdentifier.gameObject.transform.position);
        Instantiate(vfx_fusion256, tileIdentifier.gameObject.transform.position + correcPos, vfx_fusionDefaultRotation);
    }

    public void Vfx512Fusion()
    {

        //Debug.Log("Vfx magnifique enclenché en " + tileIdentifier.gameObject.transform.position);
        Instantiate(vfx_fusion512, tileIdentifier.gameObject.transform.position + correcPos, vfx_fusionDefaultRotation);
    }

    public void Vfx1024Fusion()
    {

        //Debug.Log("Vfx magnifique enclenché en " + tileIdentifier.gameObject.transform.position);
        Instantiate(vfx_fusion1024, tileIdentifier.gameObject.transform.position + correcPos, vfx_fusionDefaultRotation);
    }

    public void Vfx2048Fusion()
    {

        //Debug.Log("Vfx magnifique enclenché en " + tileIdentifier.gameObject.transform.position);
        Instantiate(vfx_fusion2048, tileIdentifier.gameObject.transform.position + correcPos, vfx_fusionDefaultRotation);
    }

    void Update()
    {
        //vfx_fusionDefaultRotation = OrientationTemoin.transform.rotation;
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//Script lecteur des tiles apparaissantes
//En communication avec les trois scripts de feedback (vfx / animation / sons) et for3DTile (celui qui setState les tiles)

public class TileIdentifier : MonoBehaviour
{
    //private new Renderer renderer;

    public For3DTile for3DTile;
    public vfxFeedback vfxFeedback;
    public AnimationFeedback animationFeedback;
    public SoundFeedback soundFeedback;
    //public LightsFeedback lightsFeedback;

    private void Awake()
    {
        //renderer = GetComponent<Renderer>();
        for3DTile = GetComponent<For3DTile>();
        vfxFeedback = GetComponent<vfxFeedback>();
        soundFeedback = GetComponent<SoundFeedback>();
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
                vfxFeedback.VfxDefaultFusion();
                break;
            case "M_8":
                Debug.Log("Tuile = " + for3DTile.matName + " appeared in " + gameObject.transform.position);
                vfxFeedback.VfxDefaultFusion();
                break;
            case "M_16":
                Debug.Log("Tuile = " + for3DTile.matName + " appeared in " + gameObject.transform.position);
                vfxFeedback.Vfx16Fusion();
                //soundFeedback.RandomSteamBlastSpecial.transform.position = gameObject.transform.position;
                soundFeedback.SfxSpecialFusion();
                if (UniqueEventsManager.Instance != null)
                {
                    UniqueEventsManager.Instance.Unlock1();
                }
                break;
            case "M_32":
                Debug.Log("Tuile = " + for3DTile.matName + " appeared in " + gameObject.transform.position);
                vfxFeedback.VfxDefaultFusion();
                if (UniqueEventsManager.Instance != null && UniqueEventsManager.Instance.canStartFlicker)
                {
                    UniqueEventsManager.Instance.StartDoorNoiseSoft();
                }
                break;
            case "M_64":
                Debug.Log("Tuile = " + for3DTile.matName + " appeared in " + gameObject.transform.position);
                vfxFeedback.Vfx64Fusion();
                soundFeedback.SfxSpecialFusion();
                if (UniqueEventsManager.Instance != null)
                {
                    UniqueEventsManager.Instance.Unlock2();
                }
                break;
            case "M_128":
                Debug.Log("Tuile = " + for3DTile.matName + " appeared in " + gameObject.transform.position);
                vfxFeedback.VfxDefaultFusion();
                if (UniqueEventsManager.Instance != null && UniqueEventsManager.Instance.canStartFlicker)
                {
                    UniqueEventsManager.Instance.StartFlickeringLight();
                }
                break;
            case "M_256":
                Debug.Log("Tuile = " + for3DTile.matName + " appeared in " + gameObject.transform.position);
                vfxFeedback.Vfx256Fusion();
                soundFeedback.SfxSpecialFusion();
                if (UniqueEventsManager.Instance != null)
                {
                    UniqueEventsManager.Instance.Unlock3();
                }
                break;
            case "M_512":
                Debug.Log("Tuile = " + for3DTile.matName + " appeared in " + gameObject.transform.position);
                vfxFeedback.Vfx512Fusion();
                soundFeedback.SfxSpecialFusion();
                if (UniqueEventsManager.Instance != null)
                {
                    UniqueEventsManager.Instance.Unlock4();
                }
                break;
            case "M_1024":
                Debug.Log("Tuile = " + for3DTile.matName + " appeared in " + gameObject.transform.position);
                if (UniqueEventsManager.Instance != null && UniqueEventsManager.Instance.canBecomeRed)
                {
                    //UniqueEventsManager.Instance.Unlock5();
                    UniqueEventsManager.Instance.BecomeRed();
                    UniqueEventsManager.Instance.StopDoorNoiseSoft();
                    UniqueEventsManager.Instance.StartDoorNoiseHard();
                    UniqueEventsManager.Instance.boxPasswordSpawn.SetActive(true);
                }
                vfxFeedback.Vfx1024Fusion();
                soundFeedback.SfxSpecialFusion();
                break;
            case "M_2048":
                Debug.Log("Tuile = " + for3DTile.matName + " appeared in " + gameObject.transform.position);
                if (UniqueEventsManager.Instance != null)
                {
                    UniqueEventsManager.Instance.StopDoorNoiseHard();
                }
                vfxFeedback.Vfx2048Fusion();
                soundFeedback.SfxSpecialFusion();
                break;


        }



        //if (for3DTile.matName == "M_2")
        //{
        //    Debug.Log("Tuile = " + for3DTile.matName + " appeared in " + gameObject.transform.position);
        //}
    }
}

using System;
using System.Collections;
using System.Collections.Generic;
using System.Numerics;
using DG.Tweening;
using UnityEngine;
using Quaternion = UnityEngine.Quaternion;
using Vector3 = UnityEngine.Vector3;

public class DotweenManager : MonoBehaviour
{
    
    
    private static DotweenManager _instance;

    public static DotweenManager Instance { get { return _instance; } }
    
    private void Awake()
    {
        if (_instance != null && _instance != this)
        {
            Destroy(this.gameObject);
        }
        else
        {
            _instance = this;
        }
    }
    
    
    
    public MouseLook mouseLook;
    
    public Transform camTransform;
    public Transform targetCamBoard;
    public Transform targetCamPlayer;
    public Transform lookAtBoard;
    public Transform lookAtFps;
    public GameObject player;
    //public float angleCam;
    public Quaternion angleCam;

    //public Vector3 lookAtBoardRotation;
    public Vector3 origineRotationCam;
    //public Vector3 origineRotationPlayer;

    private void Start()
    {
        //lookAtBoardRotation = new Vector3(-15f, 0f, 0f);
        origineRotationCam = new Vector3(0f, 0f, 0f);
        //angleCam = new Quaternion(0f, 0f, 0f, 0f);
    }


    [ContextMenu("MoveCamToBoard")]
    public void MoveCamToBoard()
    {
        //origineRotationCam = new Vector3()
        //origineRotationPlayer = player.transform.position;
        mouseLook.canMoveMouse = false;

        //camTransform.DOMove(targetCamBoard.position, 0.7f);
        //camTransform.DOLookAt(lookAtBoard.position, 0.45f);

         camTransform.DOMove(targetCamBoard.position, 0.7f).OnComplete(
             () => camTransform.DOLookAt(lookAtBoard.position, 0.45f)
         );



        //camTransform.DORotate(lookAtBoardRotation, 0.45f);

        // camTransform.DOMove(targetCamBoard.transform.position, 1).OnComplete(
        //     () => camTransform.DORotate(lookAtBoardRotation, 1f)
        // );

    }
    
    [ContextMenu("MoveCamToPlayer")]
    public void MoveCamToPlayer()
    {
        //camTransform.DOMove(targetCamPlayer.transform.position, 1);
        //camTransform.DORotate(origineRotation, 1f);

        // camTransform.DOMove(targetCamBoard.position, 0.7f);
        // camTransform.DOLookAt(lookAtFps.position, 0.45f);
        
        camTransform.DOMove(targetCamPlayer.position, 0.7f).OnComplete((
            () => camTransform.DOLookAt(lookAtBoard.position, 0.45f)
        ));
        
        //camTransform.DORotate(origineRotationCam, 0.45f);
        
         // camTransform.DOMove(targetCamPlayer.transform.position, 1).OnComplete(
         //     () => camTransform.DORotate(origineRotationCam, 1f)
         // );

        StartCoroutine(CoroutineBoolTrue());
        //mouseLook.canMoveMouse = true;
    }

    public IEnumerator CoroutineBoolTrue()
    {
        yield return new WaitForSeconds(1.15f);
        mouseLook.canMoveMouse = true;
    }
    
     
}

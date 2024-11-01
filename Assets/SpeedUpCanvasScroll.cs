using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SpeedUpCanvasScroll : MonoBehaviour
{
    public Vector3 startPos;
    public Vector3 moveValue;

    void Start()
    {
        startPos = transform.position;
        moveValue = new Vector3(0, 1, 0);
        Invoke("LoadMenu", 9.90f);
    }

    public void LoadMenu()
    {
        SceneManager.LoadScene(0);
    }

    void Update()
    {
        //transform.position = ;
        transform.position = startPos + moveValue;

        moveValue.y += 3f * Time.deltaTime;
    }
}

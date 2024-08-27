using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MasterVolumeReminder : MonoBehaviour
{
    // ----------------------------------------------------------
    //                         SINGLETON
    // ----------------------------------------------------------

    private static MasterVolumeReminder _instance;

    public static MasterVolumeReminder Instance { get { return _instance; } }

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

    // ----------------------------------------------------------
    //                         SINGLETON
    // ----------------------------------------------------------

    public float volumeMaster;


    void Start()
    {
        
    }

    void Update()
    {
        
    }
}

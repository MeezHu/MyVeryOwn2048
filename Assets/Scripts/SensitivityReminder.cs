using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SensitivityReminder : MonoBehaviour
{
    // ----------------------------------------------------------
    //                         SINGLETON
    // ----------------------------------------------------------

    private static SensitivityReminder _instance;

    public static SensitivityReminder Instance { get { return _instance; } }

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

    public float sensitivityValue;
}

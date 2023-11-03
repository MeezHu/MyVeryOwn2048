using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class TriggerEventBox : MonoBehaviour
{
    public UnityEvent inBox;
    public UnityEvent outBox;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    
    public void OnTriggerEnter(Collider other){
        inBox.Invoke();
    }

    public void OnTriggerExit(Collider other){
        outBox.Invoke();
    }
}

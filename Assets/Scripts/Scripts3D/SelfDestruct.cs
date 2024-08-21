using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SelfDestruct : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(CoroutineSelfDestruct());
    }

    IEnumerator CoroutineSelfDestruct()
    {
        yield return new WaitForSeconds(5);
        Destroy(gameObject);
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Door : MonoBehaviour
{

    GameObject GameObject;
    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
       gameObject.transform.SetPositionAndRotation(new Vector3(0f,0f,0f), Quaternion.Euler (19.329f, 0,0f));
    }
}

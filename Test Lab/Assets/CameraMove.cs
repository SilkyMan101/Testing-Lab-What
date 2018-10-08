using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraMove : MonoBehaviour {

    public Transform player = null;
    public Transform target = null;

    // Use this for initialization
    
    void LateUpdate()
    {
        this.transform.position = target.position;
    }
}

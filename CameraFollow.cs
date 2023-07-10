using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFlow : MonoBehaviour
{
    public Transform target;
    public Vector3 offset;

    private void Update()
    {
        // position of the camera = position of the target + offset
        transform.position = target.position + offset;
    }    
}

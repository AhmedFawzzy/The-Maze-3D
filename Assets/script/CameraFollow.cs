using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow : MonoBehaviour
{
      public Transform targetObject;
      public Vector3 cameraOffset ;
    void Start()
    {
        cameraOffset = transform.position - targetObject.transform.position;
    }

    // Update is called once per frame
    void LateUpdate()
    {
        Vector3 newposition = targetObject.transform.position + cameraOffset ;
        transform.position = newposition ;
    }
}

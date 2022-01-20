using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Serialization;

public class CameraFollow : MonoBehaviour
{
    [FormerlySerializedAs("target")] public Transform cammeraTarget;
    public Transform cammeraLookAt;
    public Transform projectile;
    public float smooth = 5f;


    void Start()
    {
        transform.position = cammeraTarget.position;
    }

    private void Update()
    {
    }


    void  LateUpdate ()
    {
        
        if (GameObject.FindWithTag("Projectile") != null && !ReferenceEquals(gameObject, null))
        {
            Vector3 desiredPosition = projectile.position;
        
            Vector3 smoothedPosition = Vector3.Lerp(
                transform.position, desiredPosition, smooth * Time.deltaTime);
        
            transform.position = smoothedPosition;
        
            transform.LookAt(projectile);
        }
        else
        {
            Vector3 desiredPosition = cammeraTarget.position;
        
            Vector3 smoothedPosition = Vector3.Lerp(
                transform.position, desiredPosition, smooth * Time.deltaTime);
        
            transform.position = smoothedPosition;
        
            transform.LookAt(cammeraLookAt);
        }
        
    }
}

using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Serialization;

public class CameraFollow : MonoBehaviour
{
    [FormerlySerializedAs("target")] public Transform cammeraTarget;
    public Transform lookPosition;

    void Start()
    {
        transform.position = cammeraTarget.position;
    }

    private void Update()
    {
    }

    public float distanceTime = 1;
    public Vector3 desiredPosition;

    void LateUpdate()
    {

        desiredPosition = lookPosition.position;

        Vector3 smoothedPosition = Vector3.Lerp(
            transform.position, desiredPosition, Mathf.Clamp(0, 1, distanceTime / Time.deltaTime));

        transform.position = smoothedPosition;

        transform.LookAt(cammeraTarget);

    }
}

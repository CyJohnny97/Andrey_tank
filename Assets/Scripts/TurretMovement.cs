using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
public class TurretMovement : MonoBehaviour
{
    [SerializeField]
    private  float currentX, currentY;

    [SerializeField]
    private float localX, localY;
    
    private float minRotationX = 330;
    private float maxRotationX = 359;
    
    private float minRotationZ = -30;
    private float maxRotationZ = 30;
    
    public static float Wrap(float value, float max, float min)
    {
        max -= min;
        if (max == 0)
            return min;
 
        return value - max * (float)Math.Floor((value - min) / max);
    }

    // Start is called before the first frame update
    void Start()
    {
        // Variable for computing staring mouse point
        currentX = Input.GetAxis("Mouse X");
        currentY = Input.GetAxis("Mouse Y");
        transform.Rotate(-currentY, 0, currentX, Space.Self);
    }

    // Update is called once per frame
    void Update()
    {
        // Variable for computing current mouse point
        localX = Input.GetAxis("Mouse X");
        localY = Input.GetAxis("Mouse Y");
        // Logic for computing how the barrel moves
        
            
        if (Math.Abs(localX - currentX) > 0.25 || Math.Abs(localY - currentY) > 0.25)
        {
            transform.Rotate(-localY, 0, localX, Space.Self);
            
            Vector3 currentRotation = transform.localRotation.eulerAngles;
           
        }
       
    }
}

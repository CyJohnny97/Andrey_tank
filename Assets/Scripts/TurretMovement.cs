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
        
        // Vector3(0,0,0)
        // Quaternion(0,0,0,1)
        
        float NewClamp(float value, float min, float max)
        {
            if ((double) value < (double) min)
                value = min;
            else if ((double) value > (double) max)
                value = max;
            return value;
        }
            
        if (Math.Abs(localX - currentX) > 0.25 || Math.Abs(localY - currentY) > 0.25)
        {
            transform.Rotate(-localY, 0, localX, Space.Self);
            // Debug.Log($"LocalX is {Math.Abs(localX)}");
            // Debug.Log($"LocalY is {Math.Abs(localY)}");
            // Debug.Log($"DifferenceX is {Math.Abs(localX - currentX)}");
            
            Vector3 currentRotation = transform.localRotation.eulerAngles;
            // currentRotation.x = Mathf.Clamp(currentRotation.x, minRotationX, maxRotationX);
            // Debug.Log($"currentRotation.x is {currentRotation.x}");
            // Wrap(currentRotation.z, 180, -180);
            // currentRotation.z = Mathf.Clamp(currentRotation.z, minRotationZ, maxRotationZ);
            // Debug.Log($"currentRotation.z is {currentRotation.z}");
            // transform.localRotation = Quaternion.Euler(currentRotation);
            // transform.localRotation = Quaternion.Euler(currentRotation);
        }
        
        // Debug.Log(localY);
        // Debug.Log(localX);
        
       
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Cinemachine;
using System;

public class ProjectileDetails : MonoBehaviour
{
    float startTime = 0f;
    public Transform prevCamPos;
    
    // Logic for when game projectile collides with tank
    void OnCollisionEnter(Collision other)
    {
        if (other.gameObject.CompareTag("Enemy"))
        {
            
            Destroy(gameObject);
        }
    }
    
    // Start is called before the first frame update
    void Start()
    {
        startTime = Time.time;
    }

    private void OnDestroy()
    {
        Camera.main.GetComponent<CameraFollow>().lookPosition = prevCamPos;
        Camera.main.GetComponent<CameraFollow>().cammeraTarget = GameObject.FindWithTag("Launch").transform;
    }

    // Update is called once per frame
    void Update()
    {
        if (Math.Abs(startTime - Time.time) >= 3)
        {
            Destroy(gameObject);
        }
    }
    
    
}

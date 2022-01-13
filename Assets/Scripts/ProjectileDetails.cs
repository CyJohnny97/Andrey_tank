using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Cinemachine;
using System;

public class ProjectileDetails : MonoBehaviour
{
    
    private CinemachineVirtualCamera cvm1, cvm2;
    float startTime = 0f;
    
    // Logic for when game projectile collides with tank
    void OnCollisionEnter(Collision other)
    {
        if (other.gameObject.CompareTag("Enemy"))
        {
            cvm1.Follow = GameObject.FindWithTag("Launch").transform;
            Destroy(gameObject);
            cvm2.Priority = 0;
        }
    }
    
    // Start is called before the first frame update
    void Start()
    {
        cvm1 = GameObject.FindWithTag("MainCamera").GetComponent<CinemachineVirtualCamera>();
        cvm2 = GameObject.FindWithTag("SecondCamera").GetComponent<CinemachineVirtualCamera>();
        cvm2.Priority = 2;
        cvm2.Follow = gameObject.transform;
        startTime = Time.time;
    }

    // Update is called once per frame
    void Update()
    {
        if (Math.Abs(startTime - Time.time) >= 3)
        {
            cvm1.Follow = GameObject.FindWithTag("Launch").transform;
            cvm2.Priority = 0;
            Destroy(gameObject);
        }
    }
}

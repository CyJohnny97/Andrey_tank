using System;
using System.Collections;
using System.Collections.Generic;
using Cinemachine;
using UnityEngine;

public class LaunchProjectile : MonoBehaviour
{
    public GameObject projectile;
    public float launchVelocity = 7000f;
    private GameObject ball;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetButtonDown("Fire1"))
        {
            ball = Instantiate(projectile, transform.position, transform.rotation);
            ball.GetComponent<Rigidbody>().AddRelativeForce(new Vector3(0, 0,launchVelocity));
            ball.GetComponent<ProjectileDetails>().prevCamPos = Camera.main.GetComponent<CameraFollow>().lookPosition;
            // This is moving the launch origin instead of the camera distance from ball
            // Transform space = ball.transform;
            // space.position += new Vector3(0, 0, 30);
            // Camera.main.GetComponent<CameraFollow>().lookPosition = space;
            Camera.main.GetComponent<CameraFollow>().lookPosition = ball.transform;
            Camera.main.GetComponent<CameraFollow>().cammeraTarget = ball.transform;
        }
    }
}

using System.Collections;
using System.Collections.Generic;
using Cinemachine;
using UnityEngine;

public class LaunchProjectile : MonoBehaviour
{
    [SerializeField] private CinemachineVirtualCamera Camera;
    public GameObject projectile;
    public float launchVelocity = 7000f;
    float startTime = 0f;
    private GameObject ball;

    private Transform gunTransform;
    // Start is called before the first frame update
    void Start()
    {
        gunTransform = Camera.Follow;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetButtonDown("Fire1"))
        {
            startTime = Time.time;
            ball = Instantiate(projectile, transform.position, transform.rotation);
            ball.GetComponent<Rigidbody>().AddRelativeForce(new Vector3(0, 0,launchVelocity));
            
            Debug.Log(startTime);
            Debug.Log(Time.time);
            
            Camera.Follow = ball.transform;
        }
        
        if (System.Math.Abs(startTime - Time.time) >= 3)
        {
            Camera.Follow = gunTransform;
            Destroy(ball);
        }
    }
}

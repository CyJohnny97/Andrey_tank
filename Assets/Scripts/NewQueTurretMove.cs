using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewQueTurretMove : MonoBehaviour
{
    public float mouseInputX;
     
    private float sensitivity = 10.0f;
    // Start is called before the first frame update
    void Start()
    {
        mouseInputX = Input.GetAxis("Mouse X");
    }

    // Update is called once per frame
    void Update()
    {
        transform.rotation = Quaternion.AngleAxis(mouseInputX * sensitivity * Time.deltaTime, Vector3.up);

    }
}

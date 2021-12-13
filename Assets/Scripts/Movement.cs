using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    int boost = 1;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        // Keyboard Movement
        if (Input.GetKey(KeyCode.UpArrow) || Input.GetKey(KeyCode.W)) {
            transform.Translate(Vector3.forward * Time.deltaTime * boost);
        }
        if (Input.GetKey(KeyCode.DownArrow) || Input.GetKey(KeyCode.S)) {
            transform.Translate(Vector3.back * Time.deltaTime);
        }
        if (Input.GetKey(KeyCode.LeftArrow) || Input.GetKey(KeyCode.A)) {
            transform.RotateAround(transform.position, -transform.up, Time.deltaTime * 90f);
        }
        if (Input.GetKey(KeyCode.RightArrow) || Input.GetKey(KeyCode.D)) {
            transform.RotateAround(transform.position, transform.up, Time.deltaTime* 90f);
        }
        if (Input.GetKey(KeyCode.LeftShift))
        {
            boost = 10;
        }
        else
        {
            boost = 1;
        }
    }
}
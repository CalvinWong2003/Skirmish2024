using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player_Movement : MonoBehaviour
{
    public float moveSpeed = 5f;
    public float turningSpeed = 45f;
    // Start is called before the first frame update
    void Start()
    {
        transform.position = new Vector3(0,0,1);
    }

    // Update is called once per frame
    void Update()
    {
        //if(Input.GetKey(KeyCode.W))
        //{
        //    transform.position += new Vector3(0, 0, 1);
        //}
        if (shouldMoveForward()) moveForward();
        if (shouldTurnLeft()) turnLeft();
        
    }

    private void turnLeft()
    {
        transform.Rotate(new Vector3(0,1,0), turningSpeed * 45 * Time.deltaTime);
    }

    private void moveForward()
    {
        transform.position += moveSpeed * Vector3.forward * Time.deltaTime;
    }

    private bool shouldTurnLeft()
    {
        return Input.GetKey(KeyCode.A);
    }

    private bool shouldMoveForward()
    {
        //if (Input.GetKey(KeyCode.W)) return true
        //else return false;

        transform.position += moveSpeed * transform.forward * Time.deltaTime;

        return Input.GetKey(KeyCode.W);
    }
}

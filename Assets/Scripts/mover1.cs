﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class mover1 : MonoBehaviour
{
    float speed = 5f;
    void Update()
    {       
        if (Input.GetKey(KeyCode.UpArrow))
            transform.position += new Vector3(0,speed * Time.deltaTime,0);
        else if (Input.GetKey(KeyCode.DownArrow))
            transform.position += new Vector3(0,-speed * Time.deltaTime,0);
        else if (Input.GetKey(KeyCode.RightArrow))
            transform.position += new Vector3(speed * Time.deltaTime,0,0);
        else if (Input.GetKey(KeyCode.LeftArrow))
            transform.position += new Vector3(-speed * Time.deltaTime,0,0);
    }
}

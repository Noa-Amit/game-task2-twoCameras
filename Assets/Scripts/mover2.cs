using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class mover2 : MonoBehaviour
{
    float speed = 5f;
    void Update()
    {
        if (Input.GetKey(KeyCode.W))
            transform.position += new Vector3(0,speed * Time.deltaTime,0);
        else if (Input.GetKey(KeyCode.S))
            transform.position += new Vector3(0,-speed * Time.deltaTime,0);
        else if (Input.GetKey(KeyCode.D))
            transform.position += new Vector3(speed * Time.deltaTime,0,0);
        else if (Input.GetKey(KeyCode.A))
            transform.position += new Vector3(-speed * Time.deltaTime,0,0);
    }
}

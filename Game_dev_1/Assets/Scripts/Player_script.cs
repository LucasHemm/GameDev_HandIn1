using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player_script : MonoBehaviour
{
    [SerializeField] private Rigidbody rigidbody;
    [SerializeField] private float speed = 10;
    

    void Update()
    {
        if(Input.GetKey(KeyCode.W))
        {
            rigidbody.AddForce(Vector3.back * speed);
        }
        if (Input.GetKey(KeyCode.S))
        {
            rigidbody.AddForce(Vector3.forward * speed);
        }
        if (Input.GetKey(KeyCode.A))
        {
            rigidbody.AddForce(Vector3.right * speed);
        }
       
        if (Input.GetKey(KeyCode.D))
        {
            rigidbody.AddForce(Vector3.left * speed);
        }
        
    }
}
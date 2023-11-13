using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Keeper : MonoBehaviour
{
    [SerializeField] private Rigidbody rigidbody;
    [SerializeField] private bool isGoingRigth;

    void start()
    {
        isGoingRigth = true;
    }


    // Update is called once per frame
    void Update()
    {

        if (isGoingRigth == true)
        {
            rigidbody.AddForce(Vector3.forward * 3);
        }
        else if (isGoingRigth == false)
        {
            rigidbody.AddForce(Vector3.back * 3);
        }

        
        if (transform.position.z > 110)
        {
            isGoingRigth = false;
        }
        else if (107 > transform.position.z){
            isGoingRigth = true;
        }

        
        


        
    }
}

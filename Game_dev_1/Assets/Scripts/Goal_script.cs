using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Keeper_script : MonoBehaviour
{
    [SerializeField] private Rigidbody playerRigidbody;

    private void OnTriggerEnter(Collider other)
    {
    
        if (other.gameObject.CompareTag("Ball"))
        {
            Debug.Log("Goal");
            //reset position of ball
            other.gameObject.GetComponent<Rigidbody>().velocity = Vector3.zero;
            other.gameObject.transform.position = new Vector3(107.9928f, -9f, 108.696f);
            // reset playerRigedBody
            playerRigidbody.velocity = Vector3.zero;
            playerRigidbody.transform.position = new Vector3(116f, -9f, 108.696f);
           
        }
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IntStop : MonoBehaviour
{
    public Rigidbody playerRb;


    void OnTriggerEnter(Collider other)
    {
        playerRb.isKinematic = true;
    }

    void OnTriggerExit(Collider other)
    {
        playerRb.isKinematic = false;
    }

}

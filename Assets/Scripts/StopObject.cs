using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StopObject : MonoBehaviour
{
    private GameObject Stopped;
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Construction"))
        {
            other.gameObject.GetComponent<Rigidbody>().velocity=Vector3.zero;
        }
    }
}

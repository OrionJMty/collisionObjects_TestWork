using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ControlGameZone : MonoBehaviour
{
    // Start is called before the first frame update
    private GameObject ReturnObject;
    private void OnTriggerExit(Collider other)
    {
        ReturnObject = other.gameObject;
        if (ReturnObject.gameObject.CompareTag("Construction"))
        {
            ReturnObject.transform.position=ReturnObject.transform.parent.transform.position;
        }
    }
}

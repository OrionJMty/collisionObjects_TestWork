using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeChangeState : MonoBehaviour
{
    [field:SerializeField]public Color ColisionColor { get; set; }



    // Update is called once per frame
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Construction"))
        { 
            gameObject.GetComponent<Renderer>().material.color = ColisionColor;
        }

        print("Collision detected");
    }
}



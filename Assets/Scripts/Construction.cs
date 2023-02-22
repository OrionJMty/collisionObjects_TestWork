using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;


[RequireComponent(typeof(Rigidbody))]
[RequireComponent(typeof(GameObject))]

public class Construction : MonoBehaviour, IMove
{
    private Rigidbody body;
    private Vector3 direction;
    private Transform objectPosition;
    public Transform _AttractionPoint;
    public bool StopObject;
    void Awake()
    {
        objectPosition = GetComponent<Transform>();
        body = GetComponent<Rigidbody>();
    }

    // Start is called before the first frame update

    // Update is called once per frame
    [field: SerializeField] public int Mass { get; set; }
    [field: SerializeField]  public float Speed { get; set; }
    [field: SerializeField]   public int MaxSpeed { get; set; }
    public Vector3 Direction { get; set; }
    
    void Start()
    {
    }

    public void MoveTo(Vector3 Coordinates)
    {
        direction = (Coordinates - objectPosition.position).normalized;
        if (body.velocity.magnitude > MaxSpeed)
        {
            body.velocity = body.velocity.normalized * MaxSpeed;
            Speed = MaxSpeed;
        }

        var dist = Vector3.Distance(objectPosition.position, Coordinates);
        if (dist >= 1)
        {
            body.AddForce(direction * Speed, ForceMode.Acceleration);
        }
    }

    private void FixedUpdate()
    {
        MoveTo(_AttractionPoint.position);
    }
}
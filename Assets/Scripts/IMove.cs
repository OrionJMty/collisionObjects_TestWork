using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public interface IMove
{ 
    int Mass { get; set; }
    float Speed { get; set; }
    int MaxSpeed { get; set; }
    Vector3 Direction { get; set; }
    void MoveTo(Vector3 Direction);

}

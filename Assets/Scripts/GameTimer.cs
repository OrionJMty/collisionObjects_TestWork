using System;
using System.Collections;
using System.Collections.Generic;
using UniRx;
using UnityEngine;

public class GameTimer : MonoBehaviour
{
  public static GameTimer Instance { get; private set; }

  private static float _time{ get; set; }
  public int Seconds { get; set; }

  private bool IsStarted = false;
  private void Awake()
  {
    if (Instance != null && Instance != this) 
    { 
      Destroy(this); 
    } 
    else
    {
      Instance = new GameTimer();
      Instance = this; 
    }
  }
  public GameTimer()
  {
    _time = 0;
  }
  private void Update()
  {
    if (IsStarted)
      _time += Time.deltaTime;
    Seconds = (int) _time;
  }
  public void StopTimer()
  {
    IsStarted = false;
    Seconds = 0;
  }
  public void StartTimer()
  {
    IsStarted = true;
    Seconds = 0;
  }
  public void ReloadTimer()
  {
    _time = 0;
    StartTimer();
  }
}

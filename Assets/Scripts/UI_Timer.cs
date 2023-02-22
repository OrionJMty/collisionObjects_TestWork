using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UniRx;
public class UI_Timer : MonoBehaviour
{
    public  GameTimer timer1;
    public  Text TimerCount;
    
    // Start is called before the first frame update
    void Start()
    {
        timer1=GameTimer.Instance; 
        timer1.StartTimer();
        this.ObserveEveryValueChanged(x => timer1.Seconds).Subscribe(x => TimerCount.text = x.ToString());
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}

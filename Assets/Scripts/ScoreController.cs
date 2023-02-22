using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class  ScoreController : MonoBehaviour
{
    public static ScoreController Instance { get; private set; }
 
        public int Score { get;  set; }
        public bool isCollision;
        private void Awake()
        {
            if (Instance != null && Instance != this) 
            { 
                Destroy(this); 
            } 
            else
            {
                Instance = new ScoreController();
                Instance = this; 
            }
        }

        private void Start()
        {
            isCollision = false;
        }

        private ScoreController()
        {
            this.Score = 0;
        }
 
        public static ScoreController getInstance(int score)
        {
            if (Instance == null)
            {
                Instance = new ScoreController();
            }
            return Instance;
        }

        private void ScoreIncrease(int score)
        {
            Score += score;
        }
        public void ScoreIncreaseOnOne()
        {
            ScoreIncrease(1);
        }
        public void ScoreZero()
        {
            Score = 0;
        }

        public void AddInStack(string name)
        {
            
        }
}



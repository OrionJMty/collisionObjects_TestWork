using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UniRx;

public class UI_ColisionCounter : MonoBehaviour
{
    private ScoreController _colisionCounter;
    public Text ColisionCount;

    // Start is called before the first frame update
    void Start()
    {
        _colisionCounter=ScoreController.Instance;
        this.ObserveEveryValueChanged(x => _colisionCounter.Score).Subscribe(x => ColisionCount.text = x.ToString());
  
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}

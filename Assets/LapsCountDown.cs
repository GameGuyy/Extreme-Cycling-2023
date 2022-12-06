using System;
using System.Collections;
using ExtremeCycling.Scriptables.Scripts;
using TMPro;
using UnityEngine;

public class LapsCountDown : MonoBehaviour
{
    [SerializeField] private LapCounter lapCounter;
    [SerializeField] private TextMeshProUGUI counter;
    private int lap_Counter = -1;
    public static LapsCountDown instance; 
    // Start is called before the first frame update
    private void Start()
    {
        instance = this;
        counter.text = 0 + " " + "/" + " " + lapCounter.lapsCounter;
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player") ) 
            lap_Counter++;
        if (lap_Counter == -1)
        {
            lap_Counter = 0;
            counter.text = lap_Counter + " " + "/" + " " + lapCounter.lapsCounter;
        }
            
    }
}

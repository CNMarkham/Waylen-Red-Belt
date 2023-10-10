using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TimersCountdown : MonoBehaviour
{
    public Text Laptime;
    public Text StartCountdown;

    public float TotalLapTime;
    public float TotalCountdownTime;


    void Update()
    {
        TotalLapTime -= Time.deltaTime;
        TotalCountdownTime -= Time.deltaTime;

        Laptime.text = Mathf.Round(totalLapTime).ToString();
        StartCountdown.text = Mathf.Round(totalCountdownTime).ToString();
    }
}


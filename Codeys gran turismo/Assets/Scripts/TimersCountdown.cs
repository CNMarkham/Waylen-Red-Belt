using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TimersCountdown : MonoBehaviour
{
    public Text laptime;
    public Text startCountdown;

    public float totalLapTime;
    public float totalCountdownTime;
    public CodeyMove Speed;

    
    void Update()
    {
        totalLapTime -= Time.deltaTime;
        totalCountdownTime -= Time.deltaTime;

        laptime.text=Mathf.Round(totalLapTime).ToString();
        startCountdown.text=Mathf.Round(totalCountdownTime).ToString();

        if (totalCountdownTime > 0)
        {
            Time.deltaTime -1
        }
    }
}

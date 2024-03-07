using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class TimersCountdown : MonoBehaviour
{
    public Text laptime;
    public Text startCountdown;

    public float totalLapTime;
    public float totalCountdownTime;
    public CodeyMove BlackCodey;

    
    void Update()
    {
        totalLapTime -= Time.deltaTime;

        laptime.text=Mathf.Round(totalLapTime).ToString();
        startCountdown.text=Mathf.Round(totalCountdownTime).ToString();

        if (totalCountdownTime >= 0)
        {
            totalCountdownTime -= Time.deltaTime;
            startCountdown.text = Mathf.Round(totalCountdownTime).ToString();
            BlackCodey.Speed = 0;
            
        }

        if (totalCountdownTime <= 0)
        {
            startCountdown.text = ("0");
            totalLapTime -= Time.deltaTime;
            laptime.text = Mathf.Round(totalLapTime).ToString();
            BlackCodey.Speed = 1000;
        }
        if (totalCountdownTime < 0)
        {
            Debug.Log("Time is Up");
        }
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class UITimer : MonoBehaviour
{
    public TextMeshProUGUI[] TimerTexts;
    public bool playing;
    public float timer;

    void Update()
    {

        if (playing == true && timer >= 0)
        {
            timer -= Time.deltaTime;
            int minutes = Mathf.FloorToInt(timer / 60F);
            int seconds = Mathf.FloorToInt(timer % 60F);
            int milliseconds = Mathf.FloorToInt((timer * 100F) % 100F);

            foreach (var timerText in TimerTexts)
            {
                timerText.text = minutes.ToString("00") + ":" + seconds.ToString("00") + ":" + milliseconds.ToString("00");

            }

        }

        else if (playing == true && timer <= 0)
        {
            playing = false;
            foreach (var timerText in TimerTexts)
            {
                timerText.text = ("00") + ":" + ("00") + ":" + ("00");

            }
        }

    }

}
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class GameSetiings : MonoBehaviour
{
    float gameDuration;
    public float maxGameDuration = 300f;
    public float stepGameDuration = 30f;

    public TextMeshProUGUI[] PreviewTimerTexts;


    private void Start()
    {
        gameDuration = PlayerPrefs.GetFloat(nameof(gameDuration));
        gameObject.GetComponent<UITimer>().timer = gameDuration;
        gameObject.GetComponent<UITimer>().gameDuration = gameDuration;

        SetPreviewTimer();
    }

    public void setGameDuration()
    {
        if (gameDuration < maxGameDuration)
        {
            gameDuration += stepGameDuration;
        }

        else
        {
            gameDuration = stepGameDuration;
        }

        SetPreviewTimer();

        PlayerPrefs.SetFloat(nameof(gameDuration), gameDuration);
    }

    public void SetPreviewTimer()
    {
        int minutes = Mathf.FloorToInt(gameDuration / 60F);
        int seconds = Mathf.FloorToInt(gameDuration % 60F);
        int milliseconds = Mathf.FloorToInt((gameDuration * 100F) % 100F);

        foreach (var timerText in PreviewTimerTexts)
        {
            timerText.text = minutes.ToString("00") + ":" + seconds.ToString("00") + ":" + milliseconds.ToString("00");

        }
    }

}

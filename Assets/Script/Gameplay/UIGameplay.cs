using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class UIGameplay : MonoBehaviour
{
    [SerializeField] private TMP_Text timeText, scoreText;

    [SerializeField] private int timerGame = 60;

    private float totalCurrentScore=0f;
    private float currentTime;

    [SerializeField] private UIManager _uiManager;

    private void Start()
    {
        currentTime = Mathf.Clamp(timerGame, 0, timerGame);
    }

    void Update()
    {
        TimerOn();
        ScoreText();
    }

    void TimerOn()
    {
        timeText.text = $"Timer : {currentTime}";
        if (currentTime > 0)
        {
            currentTime -= Time.deltaTime;
        }
        if (currentTime <= 0)
        {
            currentTime = 0;
            _uiManager.OpenGameOverUI();
        }
    }

    void ScoreText()
    {
        scoreText.text = $"Score: {totalCurrentScore}";
    }

    public void AddScore(float number)
    {
        totalCurrentScore += number;
    }
}

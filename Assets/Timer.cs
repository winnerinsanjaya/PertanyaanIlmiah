using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class Timer : MonoBehaviour
{
    public float timeLimit = 60.0f; // Waktu batas permainan dalam detik
    private float currentTime;
    public TextMeshProUGUI timerText;
    private bool isGameOver = false;

    private void Start()
    {
        currentTime = timeLimit;
        UpdateTimerText();
    }

    private void Update()
    {
        if (!isGameOver)
        {
            currentTime -= Time.deltaTime;

            if (currentTime <= 0)
            {
                currentTime = 0;
                isGameOver = true;
                // Tambahkan kode di sini untuk menampilkan pesan permainan berakhir atau mengakhiri permainan.
                // Contoh: GameManager.Instance.EndGame();
                Debug.Log("Waktu Habis! Permainan Berakhir!");
            }

            UpdateTimerText();
        }
    }

    void UpdateTimerText()
    {
        int minutes = Mathf.FloorToInt(currentTime / 60);
        int seconds = Mathf.FloorToInt(currentTime % 60);
        timerText.text = string.Format("{0:00}:{1:00}", minutes, seconds);
    }
}
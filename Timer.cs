using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class Timer : MonoBehaviour
{
    [SerializeField]
    private TextMeshProUGUI timerText;

    private float timeRemaining = 120f; // Initial time in seconds
    private bool timerRunning = false;

    private void Start()
    {
        timerRunning = true; // Start the timer when the object is created
    }

    private void Update()
    {
        if (timerRunning)
        {
            if (timeRemaining > 0)
            {
                timeRemaining -= Time.deltaTime; // Decrease the remaining time by the time elapsed since the last frame
                UpdateTimerDisplay(); // Update the timer display
            }
            else
            {
                timeRemaining = 0; // Ensure the timer doesn't go negative
                timerRunning = false; // Stop the timer when it reaches zero
                Debug.Log("Timer ended!"); // Optionally, you can perform any action when the timer ends
            }
        }
    }

    private void UpdateTimerDisplay()
    {
        // Calculate minutes and seconds from remaining time
        int minutes = Mathf.FloorToInt(timeRemaining / 60);
        int seconds = Mathf.FloorToInt(timeRemaining % 60);

        // Update the timer text with the formatted time
        timerText.text = string.Format("{0:00}:{1:00}", minutes, seconds);
    }
}
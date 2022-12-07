﻿using TMPro;
using UnityEngine;
using UnityEngine.UI;
public class DebugWindow : MonoBehaviour
{
    [SerializeField] private Text debugText = default;

    private void Start()
    {
        // Subscribe to log message events
        Application.logMessageReceived += HandleLog;

        // Set the starting text
        debugText.text = "Debug messages will appear here.\n\n";
    }

    private void OnDestroy()
    {
        Application.logMessageReceived -= HandleLog;
    }

    private void HandleLog(string message, string stackTrace, LogType type)
    {
        debugText.text += message + " \n";
    }
}

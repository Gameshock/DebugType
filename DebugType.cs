using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DebugType : MonoBehaviour
{
    public static void Log(string message, string color = "white")
    {
        Debug.Log($"<color={color}>{message}</color>");
    }

    public static void LogAlert(string message)
    {
        Log(message, "red");
    }

    public static void LogState(string message)
    {
        Log(message, "yellow");
    }

    public static void LogValue(string message)
    {
        Log(message, "cyan");
    }

    public static void LogOther(string message)
    {
        Log(message, "green");
    }
}

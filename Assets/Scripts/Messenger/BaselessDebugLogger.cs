using UnityEngine;

public class BaselessDebugLogger : MonoBehaviour, ILogger
{
    public void Log(string message)
    {
        Debug.Log(message);
    }
}

using System;
using UnityEngine;

/// <summary>
/// Awake後のみ使用可能なLogger(ExecutionOrder検証用)
/// </summary>
public class AwakeInitializedLogger : MonoBehaviour, ILogger
{
    private Action<string> _loggerAction = null;

    void Awake()
    {
        _loggerAction = message => Debug.Log(message);
    }

    public void Log(string message)
    {
        // Awake前に実行するとNullReferenceExceptionが発生
        _loggerAction(message);
    }

}

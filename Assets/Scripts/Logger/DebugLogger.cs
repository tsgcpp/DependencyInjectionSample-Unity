using UnityEngine;

public class DebugLogger : BaseLogger
{
    public override void Log(string message)
    {
        Debug.Log(message);
    }
}

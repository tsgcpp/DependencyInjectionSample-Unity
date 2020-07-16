using UnityEngine;

public abstract class BaseLogger : MonoBehaviour, ILogger
{
    public abstract void Log(string message);
}

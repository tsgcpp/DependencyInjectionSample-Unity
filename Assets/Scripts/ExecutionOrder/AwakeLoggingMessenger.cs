using UnityEngine;

// [DefaultExecutionOrder(-1)]  // こちらを指定することでAwake()のコールを優先可能
[RequireComponent(typeof(ILogger))]
public class AwakeLoggingMessenger : MonoBehaviour
{
    void Awake()
    {
        var logger = GetComponent<ILogger>();

        // logger取得後すぐにLogをコール
        logger.Log("Good Morning!");
    }
}

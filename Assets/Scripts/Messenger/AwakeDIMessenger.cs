using UnityEngine;
using System.Threading.Tasks;

[RequireComponent(typeof(ILogger))]
public class AwakeDIMessenger : MonoBehaviour
{
    private ILogger _logger;

    void Awake()
    {
        _logger = GetComponent<ILogger>();
    }

    public void Recv(string message)
    {
        _logger.Log(message);
    }

    // 動作確認用
    async void Start()
    {
        await Task.Delay(1000);
        Recv("Hello, I'm Messenger!");
    }
}

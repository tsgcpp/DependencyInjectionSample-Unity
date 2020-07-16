using UnityEngine;
using System.Threading.Tasks;

public class PropertyDIMessenger : MonoBehaviour
{
    [SerializeField]
    public BaseLogger logger;

    public void Recv(string message)
    {
        logger.Log(message);
    }

    // 動作確認用
    async void Start()
    {
        await Task.Delay(1000);
        Recv("Hello, I'm Messenger!");
    }
}

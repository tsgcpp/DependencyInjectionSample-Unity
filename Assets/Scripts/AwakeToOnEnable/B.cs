using UnityEngine;

public class B : MonoBehaviour
{
    private void Awake()
    {
        Debug.Log("B.Awake");
    }

    private void OnEnable()
    {
        Debug.Log("B.OnEnable");
    }
}

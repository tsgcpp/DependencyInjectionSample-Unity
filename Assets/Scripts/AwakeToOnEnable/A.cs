using UnityEngine;

public class A : MonoBehaviour
{
    private void Awake()
    {
        Debug.Log("A.Awake");
    }

    private void OnEnable()
    {
        Debug.Log("A.OnEnable");
    }
}

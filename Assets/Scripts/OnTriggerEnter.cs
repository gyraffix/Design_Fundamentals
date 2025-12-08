using UnityEngine;
using UnityEngine.Events;

public class TriggerEventInvoker : MonoBehaviour
{
    public UnityEvent onTriggerEnterEvent;

    public string requiredTag;

    void OnTriggerEnter(Collider other)
    {
        onTriggerEnterEvent?.Invoke();
        
    }
}

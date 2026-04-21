using UnityEngine;
using UnityEngine.Events;

public class Interaction : MonoBehaviour
{
    public UnityEvent OnClick;

    void Start()
    {
        
    }


    public virtual void Interact()
    {
        OnClick.Invoke();
    }
}

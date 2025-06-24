using UnityEngine;
using UnityEngine.Events;

public class EventoRecolectable : MonoBehaviour
{
    [SerializeField] private UnityEvent alRecolectar;

    public void EjecutarEvento()
    {
        alRecolectar?.Invoke();
    }
}
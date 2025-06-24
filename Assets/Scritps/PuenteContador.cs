using UnityEngine;

public class LlamadorContador : MonoBehaviour
{
    public void Ejecutar()
    {
        if (ContadorRecolectables.Instance != null)
        {
            ContadorRecolectables.Instance.SumarCofre();
        }
        else
        {
            Debug.LogWarning("No se encontró la instancia de ContadorRecolectables.");
        }
    }
}
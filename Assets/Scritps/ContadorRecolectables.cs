using UnityEngine;

public class ContadorRecolectables : MonoBehaviour
{
    public static ContadorRecolectables Instance { get; private set; }

    private int totalCofres = 0;

    private void Awake()
    {
        if (Instance != null && Instance != this)
        {
            Destroy(gameObject); // opcional pero recomendado, evita duplicados
            return;
        }
        Instance = this;
        DontDestroyOnLoad(gameObject); // opcional: para que persista entre escenas
    }

    public void SumarCofre()
    {
        totalCofres++;
        Debug.Log("Cofres recolectados: " + totalCofres);
    }

    //  Esto te permite acceder al total desde otros scripts
    public int ObtenerCantidad()
    {
        return totalCofres;
    }
}
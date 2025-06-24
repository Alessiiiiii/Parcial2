using UnityEngine;
using System;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public static GameManager Instance { get; private set; }

    private int oroTotal = 0;
    private int oroObjetivo = 1000;

    private void Awake()
    {
        if (Instance == null)
        {
            Instance = this;
            DontDestroyOnLoad(gameObject); 
        }
        else
        {
            Destroy(gameObject);
        }
    }
    public static event Action<string> OnMostrarMensaje;

    public static void MostrarMensaje(string mensaje)
    {
        Debug.Log("Se invocó el evento de mensaje: " + mensaje);
        OnMostrarMensaje?.Invoke(mensaje);
    }


    public static event Action<int> OnOroActualizado;

    public void AgregarOro(int cantidad)
    {
        oroTotal += cantidad;
        OnOroActualizado?.Invoke(oroTotal);
    }

    public void VerificarFinPartida()
    {
        if (oroTotal >= oroObjetivo)
        {
            Debug.Log("¡Partida completada! Obtuviste todo el oro.");
            // Podés cargar otra escena o mostrar UI de victoria
        }
    
        

       if (oroTotal >= oroObjetivo)
    {
        SceneManager.LoadScene(1); // asegurate que se llame así en el Build Settings
    }
}
}
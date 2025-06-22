using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class UIDialogo : MonoBehaviour
{
    [SerializeField] private TMP_Text textoDialogo;
    [SerializeField] private GameObject panelDialogo;
    private void Start()
    {
        panelDialogo.SetActive(false);
    }
    private void OnEnable()
    {
        

        GameManager.OnMostrarMensaje += Mostrar;
    }

    private void OnDisable()
    {
        GameManager.OnMostrarMensaje -= Mostrar;
    }

    void Mostrar(string mensaje)
    {
        textoDialogo.text = mensaje;
        panelDialogo.SetActive(true);
        CancelInvoke();
        Invoke(nameof(Esconder), 3f); // Oculta tras 3 segundos
    }

    void Esconder()
    {
        panelDialogo.SetActive(false);
    }
}
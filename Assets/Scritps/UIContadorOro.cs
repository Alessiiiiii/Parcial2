using UnityEngine;
using UnityEngine.UI;
using TMPro;


public class UIContadorOro : MonoBehaviour
{
    [SerializeField] private TMP_Text textoOro;    

    private void OnEnable()
    {
        GameManager.OnOroActualizado += ActualizarTexto;
    }

    private void OnDisable()
    {
        GameManager.OnOroActualizado -= ActualizarTexto;
    }

    private void Start()
    {
        // Inicializamos el texto con el oro actual
        textoOro.text = "Oro: 0";
    }

    private void ActualizarTexto(int nuevoOro)
    {
        textoOro.text = "Oro: " + nuevoOro;
    }
}
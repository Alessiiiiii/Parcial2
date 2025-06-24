using TMPro;
using UnityEngine;



public class ActualizarContadorUI : MonoBehaviour
{
    public TextMeshProUGUI texto; // o TextMeshProUGUI si us�s TMP

    private void Update()
    {
        texto.text = "Cofres recolectados: " + ContadorRecolectables.Instance.ObtenerCantidad();
    }
}

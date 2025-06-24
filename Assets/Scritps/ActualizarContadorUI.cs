using TMPro;
using UnityEngine;



public class ActualizarContadorUI : MonoBehaviour
{
    public TextMeshProUGUI texto; // o TextMeshProUGUI si usás TMP

    private void Update()
    {
        texto.text = "Cofres recolectados: " + ContadorRecolectables.Instance.ObtenerCantidad();
    }
}

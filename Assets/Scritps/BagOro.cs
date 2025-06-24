using UnityEngine;

public class BagOro : TempleObject
{
    [SerializeField] private int oro = 1000;

    public override void Interact()
    {
       
        GameManager.MostrarMensaje("Objetivo Cumplido, encontraste la bolsa de Oro");
        GameManager.Instance.AgregarOro(oro);
        GameManager.Instance.VerificarFinPartida();
        Destroy(gameObject);
    }
}

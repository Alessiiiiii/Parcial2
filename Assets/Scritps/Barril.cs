using UnityEngine;

public class Barril : TempleObject
{
    public override void Interact()
    {
        Debug.Log("Pista: 'Busca la bolsa de oro cerca del altar.'");
        GameManager.MostrarMensaje("Pista: 'Busca la bolsa de oro cerca del altar.'");
    }
}
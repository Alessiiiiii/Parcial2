using UnityEngine;

public class Barril : TempleObject
{
    public override void Interact()
    {
        
        GameManager.MostrarMensaje("Pista: 'Busca la bolsa de oro cerca del altar.'");
    }
}
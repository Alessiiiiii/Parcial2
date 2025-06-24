using UnityEngine;

public class BarrilPista : Barril
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    public override void Interact()
    {

        GameManager.MostrarMensaje("Pista: 'Estas muy cerca'");
    }
}


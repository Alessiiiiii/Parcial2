using UnityEngine;

public class CofreChico : Cofre
{
    private void Start()
    {
        // Podés modificar el valor de oro si querés que sea menor
    }
    public override void Interact()
    {
        
        GameManager.MostrarMensaje("Hola, soy Cofre Chico.Llevate mi oro");
        base.Interact();

    }
}




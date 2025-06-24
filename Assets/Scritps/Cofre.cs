using UnityEngine;

public class Cofre : TempleObject
{
    [SerializeField] protected int oro = 200;

    public override void Interact()
    {
      
        GameManager.MostrarMensaje("Cofre abierto. Oro obtenido: " + oro);
        GameManager.Instance.AgregarOro(oro);
        Destroy(gameObject);
    }
}

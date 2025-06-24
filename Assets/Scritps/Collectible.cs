using UnityEngine;

public class Collectible : Cofre
{
    protected new int oro = 50;

    public override void Interact()
    {
        GameManager.Instance.AgregarOro(oro);
        GetComponent<EventoRecolectable>()?.EjecutarEvento();
        Destroy(gameObject);
    }
}
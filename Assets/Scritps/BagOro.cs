using UnityEngine;

public class BagOro : TempleObject
{
    [SerializeField] private int oro = 100;

    public override void Interact()
    {
        GameManager.Instance.AgregarOro(oro);
        Debug.Log("¡Encontraste la bolsa de oro!");
        Destroy(gameObject);
        GameManager.Instance.VerificarFinPartida();
    }
}

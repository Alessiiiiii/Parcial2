using UnityEngine;

public class Cofre : TempleObject
{
    [SerializeField] private int oro = 50;

    public override void Interact()
    {
        GameManager.Instance.AgregarOro(oro);
        Debug.Log("Cofre abierto. Oro obtenido: " + oro);
        Destroy(gameObject);
    }
}

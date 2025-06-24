using UnityEngine;

public class CofreChico : TempleObject
{
    [SerializeField] private int oro = 100;
    public override void Interact()
    {
        
        GameManager.MostrarMensaje("Hola, soy Cofre Chico.Tengo Oro");
        GameManager.Instance.AgregarOro(oro);
        Destroy(gameObject);

    }
}




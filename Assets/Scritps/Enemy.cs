using UnityEngine;

public class ObjectoData : MonoBehaviour, IPresentacion, ITakeDamage
{
    public ObjectData objetoData;

    void Start()  
    {
        
    }

    public void Accion()  
    {
        Debug.Log($"{objetoData.nombre} dice: {objetoData.saludo}");
    }

    public void RecibirDanio(int cantidad)  
    {
        objetoData.vida -= cantidad;
        Debug.Log($"{objetoData.nombre} recibi� {cantidad} de da�o. Vida restante: {objetoData.vida}");
    }
}
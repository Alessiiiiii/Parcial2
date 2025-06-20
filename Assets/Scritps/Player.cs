using UnityEngine;

public class Player : MonoBehaviour
{
    public float velocidad = 5f;

    void Update()  
    {
        MoverJugador();

        if (Input.GetKeyDown(KeyCode.R))  
        {
            InteractuarConObjeto();
        }

        if (Input.GetKeyDown(KeyCode.E))  
        {
            AtacarObjeto();
        }
    }

    void MoverJugador()
    {
        float horizontal = Input.GetAxis("Horizontal") * velocidad * Time.deltaTime;
        float vertical = Input.GetAxis("Vertical") * velocidad * Time.deltaTime;
        transform.Translate(horizontal, 0, vertical); 

       }

    Objeto FindClosestObjeto()
    {
        float rangoDeteccion = 5f;
        Collider[] colliders = Physics.OverlapSphere(transform.position, rangoDeteccion);

        Objeto ObjetoMasCercano = null;
        float distanciaMinima = Mathf.Infinity;

        foreach (Collider collider in colliders)
        {
            Objeto Objeto = collider.GetComponent<Objeto>();
            if (Objeto != null)
            {
                float distancia = Vector3.Distance(transform.position, Objeto.transform.position);
                if (distancia < distanciaMinima)
                {
                    distanciaMinima = distancia;
                    ObjetoMasCercano = Objeto;
                }
            }
        }
        return ObjetoMasCercano;
    }

    void InteractuarConObjeto()
    {
        Object ObjetoCercano = FindClosestObjeto();
        if (ObjetoCercano != null)
        {
            ObjetoCercano.Accion();
        }
    }

    void AtacarObjeto()
    {
        Objeto ObjetoCercano = FindClosestObjeto();

        if (ObjetoCercano != null)
        {
            ObjetoCercano.RecibirDanio(10);
        }
    }
}
using UnityEngine;

public class BarrilPista : Barril
{
    private bool subiendo = false;

    void Update()
    {
        if (subiendo)
            transform.Translate(Vector3.up * 2f * Time.deltaTime);
    }

    public override void Interact()
    {
        GameManager.MostrarMensaje("Pista: 'Est�s muy cerca'");
        subiendo = true;
        Destroy(gameObject, 3f); 
    }
}
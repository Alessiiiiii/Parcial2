using UnityEngine;

public class PlayerInteraction : MonoBehaviour
{

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.E))
        {
            Ray ray = new Ray(transform.position, transform.forward);
            if (Physics.Raycast(ray, out RaycastHit hit, 3f))
            {
                Debug.Log("Raycast pegó a: " + hit.collider.name + " (objeto)");

                var interactableDirecto = hit.collider.GetComponent<IInteractable>();
                var interactablePadre = hit.collider.GetComponentInParent<IInteractable>();

                if (interactableDirecto != null)
                {
                    Debug.Log("Encontró IInteractable DIRECTAMENTE");
                    interactableDirecto.Interact();
                }
                else if (interactablePadre != null)
                {
                    Debug.Log("Encontró IInteractable EN EL PADRE");
                    interactablePadre.Interact();
                }
                else
                {
                    Debug.Log("NO se encontró IInteractable ni directo ni en padres.");
                }
            }
            else
            {
                Debug.Log("El raycast no pegó en ningún objeto.");
            }
        }
    }
}
using UnityEngine;

public class PlayerInteraction : MonoBehaviour
{
    private const float interactionDistance = 3f;

    void Update()
    {
        if (!Input.GetKeyDown(KeyCode.E)) return;

        if (Physics.Raycast(transform.position, transform.forward, out RaycastHit hit, interactionDistance))
        {
            Debug.Log($"Raycast pegó a: {hit.collider.name}");

            IInteractable interactable = hit.collider.GetComponent<IInteractable>()
                                        ?? hit.collider.GetComponentInParent<IInteractable>();

            if (interactable != null)
            {
                Debug.Log("Se encontró IInteractable");
                interactable.Interact();
            }
            else
            {
                Debug.Log("NO se encontró IInteractable.");
            }
        }
        else
        {
            Debug.Log("El raycast no pegó en ningún objeto.");
        }
    }
}
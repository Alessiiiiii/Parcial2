using UnityEngine;
using UnityEngine.InputSystem;

[RequireComponent(typeof(CharacterController))]
public class PlayerController : MonoBehaviour
{
    public float velocidad = 5f;
    public float fuerzaSalto = 3f;
    public float gravedad = -9.81f;
    public Transform camara;

    private CharacterController controller;
    private Vector2 inputMovimiento;
    private Vector3 velocidadVertical;
    private bool estaEnSuelo;

    void Start()
    {
        controller = GetComponent<CharacterController>();
    }

    void Update()
    {
        estaEnSuelo = controller.isGrounded;
        if (estaEnSuelo && velocidadVertical.y < 0)
            velocidadVertical.y = -2f;

        Vector3 direccion = Vector3.zero;
        if (camara != null && inputMovimiento != Vector2.zero)
        {
            Vector3 forward = camara.forward;
            Vector3 right = camara.right;
            forward.y = 0f; right.y = 0f;
            forward.Normalize(); right.Normalize();

            direccion = forward * inputMovimiento.y + right * inputMovimiento.x;

            Quaternion rotacion = Quaternion.LookRotation(direccion);
            transform.rotation = Quaternion.Slerp(transform.rotation, rotacion, Time.deltaTime * 10f);
        }

        velocidadVertical.y += gravedad * Time.deltaTime;
        Vector3 movimiento = direccion * velocidad;
        movimiento.y = velocidadVertical.y;

        controller.Move(movimiento * Time.deltaTime);
    }

    public void OnMove(InputAction.CallbackContext context)
    {
        inputMovimiento = context.ReadValue<Vector2>();
    }

    public void OnSaltar(InputAction.CallbackContext context)
    {
        if (context.performed && estaEnSuelo)
        {
            velocidadVertical.y = Mathf.Sqrt(fuerzaSalto * -2f * gravedad);
        }
    }
}
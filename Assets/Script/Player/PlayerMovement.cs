using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerMovement : MonoBehaviour, PlayerInput.IPlayerActions // input system created
{
    public float speed;
    public float lookSpeed;
    public Transform playerTransform;
    public Transform cameraTransform;

    Vector2 _moveDirection;
    Vector2 _lookDirection;

    private float minHeadRotate = -100f;
    private float maxHeadRotate = 100f;

    float lookX;
    float lookY;

    void Start()
    {
        //Cursor.visible = false;
        //Cursor.lockState = CursorLockMode.Locked;
    }

    public void OnLook(InputAction.CallbackContext context)
    {
        _lookDirection = context.ReadValue<Vector2>();

        lookY = Mathf.Clamp(lookY, minHeadRotate, maxHeadRotate);
        playerTransform.localEulerAngles = new Vector3(0, lookX, 0);
        cameraTransform.localEulerAngles = new Vector3(lookY, 0, 0);

        // Rotation du joueur autour de l'axe X (vertical)
        // Player rotation around the X axis (vertical)
        lookX += context.ReadValue<Vector2>().x * lookSpeed * Time.deltaTime;

        // Rotation de la cam�ra autour de l'axe Y (horizontal)
        // Camera rotation around the Y axis (horizontal)
        lookY -= context.ReadValue<Vector2>().y * lookSpeed * Time.deltaTime;
    }

    public void OnMove(InputAction.CallbackContext context)
    {
        _moveDirection = context.ReadValue<Vector2>();
    }

    void Update()
    {
        Vector3 moveDirection = new Vector3(_moveDirection.x, 0, _moveDirection.y);
        playerTransform.Translate(moveDirection * (speed * Time.deltaTime));

        // Si la direction verticale (_moveDirection.y) est positive, utilise cette direction pour avancer devant
        // If the vertical direction (_moveDirection.y) is positive, use this direction to move forward
        //if (_moveDirection.y > 0)
        //{
        //    Vector3 forwardDirection = cameraTransform.forward * _moveDirection.y;
        //    playerTransform.Translate(forwardDirection * (speed * Time.deltaTime));
        //}
    }
}

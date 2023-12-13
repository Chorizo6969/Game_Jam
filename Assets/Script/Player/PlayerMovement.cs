using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerMovement : MonoBehaviour, PlayerInput.IPlayerActions
{
    public float speed;
    public Transform playerTransform;

    Vector2 _moveDirection;

    public void OnLook(InputAction.CallbackContext context)
    {
        throw new System.NotImplementedException();
    }

    public void OnMove(InputAction.CallbackContext context)
    {
        _moveDirection = context.ReadValue<Vector2>();
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 moveDirection = new Vector3(_moveDirection.x, 0, _moveDirection.y);
        playerTransform.Translate(moveDirection * (speed * Time.deltaTime));

        // Si la direction verticale (_moveDirection.y) est positive, utilise cette direction pour avancer devant
        if (_moveDirection.y > 0)
        {
            Vector3 forwardDirection = playerTransform.forward * _moveDirection.y;
            playerTransform.Translate(forwardDirection * (speed * Time.deltaTime));
        }


    }
}

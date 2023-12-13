using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerMovement : MonoBehaviour, PlayerInput.IPlayerActions
{
    public float speed;
    public Transform playerTransform;

    private Vector3 _direction;

    public void OnLook(InputAction.CallbackContext context)
    {
        throw new System.NotImplementedException();
    }

    public void OnMove(InputAction.CallbackContext context)
    {
        _direction = context.ReadValue<Vector2>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}

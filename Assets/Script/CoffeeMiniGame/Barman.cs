using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class Barman : MonoBehaviour, PlayerInput.IPlayerActions
{
    public Camera mainCamera;

    public void OnInteract(InputAction.CallbackContext context)
    {
        Ray ray = mainCamera.ScreenPointToRay(Input.mousePosition);
        RaycastHit hit;

        if (Physics.Raycast(ray, out hit))
        {
            TouchSomething(hit.transform.gameObject);
        }
    }

    public void TouchSomething(GameObject gameObject)
    {
        if (gameObject.name == "Coffee")
        {
            Debug.Log(gameObject.name);
        }

        if (gameObject.name == "Tea")
        {
            Debug.Log(gameObject.name);
        }

        if (gameObject.name == "Chocolat")
        {
            Debug.Log(gameObject.name);
        }
    }

    public void OnMove(InputAction.CallbackContext context) //pour l'input manager
    {
        //
    }
    public void OnLook(InputAction.CallbackContext context)
    {
        //
    }
}

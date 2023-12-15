using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class Barman : MonoBehaviour, PlayerInput.IPlayerActions
{
    public Camera mainCamera;

    public bool pickUpCoffee;
    public bool pickUpTea;
    public bool pickUpChocolat;

    public CoffeeRequest coffeeRequest;
    public TeaRequest teaRequest;
    public ChocolatRequest chocolatRequest;

    public GameObject drink;

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

        drink = gameObject;
        Debug.Log(gameObject.tag + " tag");
        Debug.Log(gameObject.name + " name");

    }
    public void OnTriggerEnter(Collider collider)
    {
        if (collider.gameObject.name == "Client")
        {
            coffeeRequest.IHaveSomething(drink);
            teaRequest.IHaveSomething(drink);
            chocolatRequest.IHaveSomething(drink);
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

using TMPro;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.InputSystem;

public class Barman : MonoBehaviour, PlayerInput.IPlayerActions
{
    public Camera mainCamera;
    public TextMeshProUGUI drinkText;
    public LayerMask mask;
    public float distance;

    private string player = "Player";
    private string coffee= "coffee";
    private string tea = "tea";
    private string chocolat = "chocolat";

    public void OnInteract(InputAction.CallbackContext context)
    {
        Ray ray = mainCamera.ScreenPointToRay(Input.mousePosition);
        RaycastHit hit;

        if (Physics.Raycast(ray, out hit,distance, mask))
        {
            TouchSomething(hit.transform.gameObject);
        }
    }

    public void TouchSomething(GameObject drink)
    {

        if (drink.name == "Coffee")
        {
            gameObject.tag = coffee;
        }

        if (drink.name == "Tea")
        {
            gameObject.tag = tea;
        }

        if (drink.name == "Chocolat")
        {
            gameObject.tag = chocolat;
        }

        drinkText.text = drink.name;
    }

    public void OnTriggerEnter(Collider collider)
    {
        gameObject.tag = player;
        drinkText.text = "none";
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

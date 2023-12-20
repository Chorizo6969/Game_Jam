using UnityEngine;
using UnityEngine.InputSystem;

public class Barman : MonoBehaviour, PlayerInput.IPlayerActions
{
    public Camera mainCamera;
    public LayerMask mask;
    public float distance;

    public GameObject inventory;
    public bool handFull;

    public void OnInteract(InputAction.CallbackContext context)
    {
        Ray ray = mainCamera.ScreenPointToRay(Input.mousePosition);
        RaycastHit hit;

        if (Physics.Raycast(ray, out hit, distance))
        {
            TouchSomething(hit.transform.gameObject);
        }
    }

    public void TouchSomething(GameObject drink)
    {
        if (!handFull)
        {
            if (drink.tag == "coffee")
            {
                handFull = true;
                gameObject.tag = "coffee";
                inventory.transform.GetChild(1).gameObject.SetActive(true);
            }

            if (drink.tag == "tea")
            {
                handFull = true;
                gameObject.tag = "tea";
                inventory.transform.GetChild(2).gameObject.SetActive(true);
            }
        }

        //if (drink.tag == "Chocolat")
        //{
        //    gameObject.tag = chocolat;
        //}
    }

    public void OnTriggerEnter(Collider collider)
    {
        if (collider.name == "Client(Clone)")
        {
            handFull = false;
            //gameObject.tag = "Player";
            inventory.transform.GetChild(2).gameObject.SetActive(false);
            inventory.transform.GetChild(1).gameObject.SetActive(false);
        }
    }
    public void OnLook(InputAction.CallbackContext context)
    {
        //
    }
    public void OnMove(InputAction.CallbackContext context)
    {
        //
    }
}

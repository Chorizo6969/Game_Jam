using System.Collections;
using System.Collections.Generic;
using UnityEditor.PackageManager;
using UnityEngine;

public class PlayerInteractable : MonoBehaviour
{
    public Camera cam;

    [SerializeField]
    private float distance = 3f;

    [SerializeField]
    private LayerMask mask;

    private Player_Ui playerUI;
    private PlayerInput inputManager;
    private Interactable interactable;  //test pour savoir si elle est visible

    void Start()
    {
        playerUI = GetComponent<Player_Ui>();
    }

    void Update()
    {
        playerUI.UpdateText(string.Empty);
        Ray ray = new Ray(cam.transform.position, cam.transform.forward);
        Debug.DrawRay(ray.origin, ray.direction * distance);
        RaycastHit hitInfo;
        if (Physics.Raycast(ray, out hitInfo, distance, mask))
        {
            interactable = hitInfo.collider.GetComponent<Interactable>(); // Mettre à jour interactable
            if (interactable != null)
            {
                playerUI.UpdateText(interactable.promptMessage);
            }
        }
        else
        {
            interactable = null;
        }
    }

    public void OnInteract()
    {
        if (interactable != null)
        {
            Debug.Log("A");
            interactable.BaseInteract();
        }
    }
}
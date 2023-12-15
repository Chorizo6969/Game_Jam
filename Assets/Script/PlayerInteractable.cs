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
        Debug.DrawRay(ray.origin, ray.direction * distance * 3);//Pour changer le Raycast
        RaycastHit hitInfo;
        if (Physics.Raycast(ray, out hitInfo, distance * 2, mask)) //Pour changer la portée de détection du Raycast
        {
            interactable = hitInfo.collider.GetComponent<Interactable>(); // Mettre � jour interactable
            if (interactable != null)
            {
                playerUI.UpdateText(interactable.promptMessage); //On affiche un texte lorsque le raycast touche un interactible
            }
        }
        else
        {
            interactable = null; // Sinon interactable devient nulle et n'affiche donc rien
        }
    }

    public void OnInteract() //Lorsque l'on appuie sur "E" sur un objet
    {
        if (interactable != null)
        {
            Debug.Log("A");
            interactable.BaseInteract();
        }
    }
}
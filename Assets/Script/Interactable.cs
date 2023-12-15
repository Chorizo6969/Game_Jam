using UnityEngine;

public abstract class Interactable : MonoBehaviour
{
    public string promptMessage;
    public void BaseInteract()
    {
        Interact(); //Lance la fct Interact
    }
    protected virtual void Interact()//Nous sommes dans une classe abstraite, donc les enfants de Interactable vont récupérer le code ci-dessous :
    {
        //Pour l'instant je ne lègue rien de façon obligeatoire
    }
}

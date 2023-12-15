using UnityEngine;

public abstract class Interactable : MonoBehaviour
{
    public string promptMessage;
    public void BaseInteract()
    {
        Interact(); //Lance la fct Interact
    }
    protected virtual void Interact()//Nous sommes dans une classe abstraite, donc les enfants de Interactable vont r�cup�rer le code ci-dessous :
    {
        //Pour l'instant je ne l�gue rien de fa�on obligeatoire
    }
}

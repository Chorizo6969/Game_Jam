//Script enfant de Interacable (et non de MonoBehaviour)
using UnityEngine;

public class Environnement : Interactable
{
    protected override void Interact()//Cette fct Interact permet d'afficher dans la console un message
    {
        this.GetComponentInParent<Dialogue>().Activate();
        Debug.Log("Tu as collecté : " + gameObject.name);
    }
}

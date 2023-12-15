//Script enfant de Interacable (et non de MonoBehaviour)
using UnityEngine;

public class Destroy : Interactable
{
    public GameObject gameobject;
    protected override void Interact()//fct qui permet de détruire un object lorsque l'on interagit avec lui
    {
        Destroy(gameobject);
    }
}

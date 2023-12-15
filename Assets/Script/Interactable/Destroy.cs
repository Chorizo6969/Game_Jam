//Script enfant de Interacable (et non de MonoBehaviour)
using UnityEngine;

public class Destroy : Interactable
{
    public GameObject _gameobject;
    protected override void Interact()//fct qui permet de détruire un object lorsque l'on interagit avec lui
    {
        Debug.Log(_gameobject.transform.parent.gameObject.name);
        this.GetComponentInParent<Dialogue>().Activate();
        //Dialogue.Instance.Activate();
        Destroy(_gameobject);
    }
}

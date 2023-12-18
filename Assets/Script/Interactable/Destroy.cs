//Script enfant de Interacable (et non de MonoBehaviour)
using UnityEngine;

public class Destroy : Interactable
{
    public GameObject _gameObject;
    protected override void Interact()//fct qui permet de détruire un object lorsque l'on interagit avec lui
    {
        ForestManager.Instance.objectPickUp.Add(_gameObject);
        //Debug.Log(_gameObject.transform.parent.gameObject.name);
        this.GetComponentInParent<Dialogue>().Activate();
        //Dialogue.Instance.Activate();
        Destroy(_gameObject);
    }
}

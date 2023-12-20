//Script enfant de Interacable (et non de MonoBehaviour)
using UnityEngine;
using UnityEngine.SceneManagement;

public class Destroy : Interactable
{
    public GameObject _gameObject;
    protected override void Interact()//fct qui permet de d�truire un object lorsque l'on interagit avec lui
    {
        //Debug.Log(_gameObject.transform.parent.gameObject.name);
        this.GetComponentInParent<Dialogue>().Activate();
        //Dialogue.Instance.Activate();
        Destroy(_gameObject);
    }
}

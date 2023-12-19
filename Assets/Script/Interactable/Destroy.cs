//Script enfant de Interacable (et non de MonoBehaviour)
using UnityEngine;
using UnityEngine.SceneManagement;

public class Destroy : Interactable
{
    public GameObject _gameObject;
    protected override void Interact()//fct qui permet de d�truire un object lorsque l'on interagit avec lui
    {
        ForestManager.Instance.objectPickUp.Add(_gameObject);
        if (SceneManager.sceneCount == 2) //scène de la forêt
        {
            for (int i = 0; i < ForestManager.Instance.objectPickUp.Count; i++)
            {
                if (ForestManager.Instance.objectPickUp[i].name == GetComponent<Collider>().gameObject.name)
                {
                    GetComponent<Collider>().gameObject.transform.GetChild(0).gameObject.SetActive(true);
                    ForestManager.Instance.objectPickUp.Remove(GetComponent<Collider>().gameObject);
                    break;
                }
                else
                {
                    break;
                }
            }
        }

        //Debug.Log(_gameObject.transform.parent.gameObject.name);
        this.GetComponentInParent<Dialogue>().Activate();
        //Dialogue.Instance.Activate();
        Destroy(_gameObject);
    }
}

//Script enfant de Interacable (et non de MonoBehaviour)
using UnityEngine;

public class RecupObject : Interactable

{
    protected override void Interact()//fct qui permet de d�truire un object lorsque l'on interagit avec lui
    {
        ForestManager.Instance.objectPickUp.Add(gameObject);

        for (int i = 0; i < ForestManager.Instance.objectInInventory.Count; i++)
        {
            if (gameObject.name == ForestManager.Instance.objectInInventory[i].name)
            {
                ForestManager.Instance.objectInInventory[i].SetActive(true);
                gameObject.SetActive(false);
                break;
            }
        }
        this.GetComponentInParent<Dialogue>().Activate();
        this.GetComponentInParent<Music>().PlayMusic();
        gameObject.SetActive(false);
    }
}

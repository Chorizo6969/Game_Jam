using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectInPlace : MonoBehaviour
{
    private GameObject removeObject;
    public void OnTriggerEnter(Collider collider)
    {
        for (int i = 0; i < ForestManager.Instance.objectPickUp.Count; i++) //permet de v�rifier si le joueur poss�de bien l'objet qui doit aller dans cette zone, si oui, il sera activ�   
        {
            if (ForestManager.Instance.objectPickUp[i].name == collider.gameObject.name)
            {
                removeObject = ForestManager.Instance.objectPickUp[i];

                collider.gameObject.transform.GetChild(0).gameObject.SetActive(true);
                ForestManager.Instance.objectPickUp.Remove(removeObject);
                ForestManager.Instance.objectInInventory[i].SetActive(false);

                break;
            }
            
        }

        for (int i = 0; i < ForestManager.Instance.objectInInventory.Count; i++) //retire l'ui
        {
            if (ForestManager.Instance.objectInInventory[i].name == collider.gameObject.name)
            {
                ForestManager.Instance.objectInInventory[i].SetActive(false);

                break;
            }
        }
    }
}

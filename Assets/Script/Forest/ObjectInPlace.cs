using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectInPlace : MonoBehaviour
{
    public void OnTriggerEnter(Collider collider)
    {
        for (int i = 0; i < ForestManager.Instance.objectPickUp.Count; i++) //permet de v�rifier si le joueur poss�de bien l'objet qui doit aller dans cette zone, si oui, il sera activ�   
        {
            if (ForestManager.Instance.objectPickUp[i].name == collider.gameObject.name)
            {
                collider.gameObject.transform.GetChild(0).gameObject.SetActive(true);
                ForestManager.Instance.objectPickUp.Remove(collider.gameObject);
                ForestManager.Instance.objectInInventory[i].SetActive(false);
                break;
            }
            else
            {
                break;
            }
        }
    }
}

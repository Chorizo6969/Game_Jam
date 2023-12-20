using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectInPlace : MonoBehaviour
{
    private GameObject removeObject;

    [SerializeField]
    private GameObject _treeWithoutElevator;
    [SerializeField]
    private GameObject _treeWithElevator;

    private int _index = 0;


    public void OnTriggerEnter(Collider collider)
    {
        for (int i = 0; i < ForestManager.Instance.objectPickUp.Count; i++) //permet de vérifier si le joueur possède bien l'objet qui doit aller dans cette zone, si oui, il sera activé   
        {
            if (ForestManager.Instance.objectPickUp[i].name == collider.gameObject.name)
            {
                removeObject = ForestManager.Instance.objectPickUp[i];

                collider.gameObject.transform.GetChild(0).gameObject.SetActive(true);
                ForestManager.Instance.objectPickUp.Remove(removeObject);
                ForestManager.Instance.objectInInventory[i].SetActive(false);
                _index++;
                Debug.Log(_index);
                if (_index == 6)
                {
                    _treeWithoutElevator.SetActive(false);
                    _treeWithElevator.SetActive(true);
                }

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

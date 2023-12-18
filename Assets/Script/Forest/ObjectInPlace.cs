using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectInPlace : MonoBehaviour
{
    public void OnTriggerEnter(Collider collider)
    {
        for (int i = 0; i < ForestManager.Instance.objectPickUp.Count; i++)
        {
            if (ForestManager.Instance.objectPickUp[i].name == collider.gameObject.name)
            {
                collider.gameObject.transform.GetChild(0).gameObject.SetActive(true);
                ForestManager.Instance.objectPickUp.Remove(collider.gameObject);
                break;
            }
            else
            {
                break;
            }
        }
    }
}

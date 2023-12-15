using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DropObject : MonoBehaviour
{
    public void OnTriggerEnter(Collider collider)
    {
        collider.gameObject.transform.GetChild(0).gameObject.SetActive(true);
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectInPlace : MonoBehaviour
{
    public void OnTriggerEnter(Collider collider)
    {
        ForestManager.Instance.ObjectInHisPlace();
    }
}

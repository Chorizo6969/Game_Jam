using System.Collections;
using UnityEngine;

public class TeaRequest : MonoBehaviour
{
    public void OnTriggerEnter(Collider collider)
    {
        if (BarManager.Instance.drink)
        {            
            BarManager.Instance.drink = false;
        }
    }
    
}
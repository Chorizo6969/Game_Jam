using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TeaRequest : MonoBehaviour
{
    public void OnTriggerEnter(Collider collider)
    {
        if (collider.tag == "tea")
        {
            BarManager.Instance.HappyClient();
            Destroy(this.gameObject);
        }
        else
        {
            BarManager.Instance.AngryClient();
            Destroy(this.gameObject);
        }
    }
}
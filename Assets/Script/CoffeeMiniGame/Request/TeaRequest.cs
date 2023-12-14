using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TeaRequest : MonoBehaviour
{
    public void IHaveSomething(GameObject gameObject)
    {
        if (gameObject.name == "Tea")
        {
            BarManager.Instance.clientGoAway = false;
            BarManager.Instance.HappyClient();
            Destroy(gameObject);
        }
        else
        {
            BarManager.Instance.clientGoAway = false;
            BarManager.Instance.TimeTooLong();
            Destroy(gameObject);
        }
    }
}

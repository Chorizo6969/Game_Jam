using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoffeeRequest : MonoBehaviour
{
    public void IHaveSomething(GameObject gameObject)
    {
        if (gameObject.tag == "coffee")
        {
            BarManager.Instance.clientGoAway = false;
            BarManager.Instance.HappyClient();
            Destroy(this.gameObject);
        }
        else
        {
            BarManager.Instance.clientGoAway = false;
            BarManager.Instance.TimeTooLong();
            Destroy(this.gameObject);
        }
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoffeeRequest : MonoBehaviour
{
    public void IHaveSomething()
    {
        BarManager.Instance.HappyClient();
    }
}

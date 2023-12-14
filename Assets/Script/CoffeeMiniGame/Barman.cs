using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Barman : MonoBehaviour
{
    void Start()
    {
        
    }

    public void TouchSomething(GameObject gameObject)
    {
        if(gameObject.name == "Coffee")
        {
            Debug.Log(gameObject.name);
        }
        
        if(gameObject.name == "Tea")
        {
            Debug.Log(gameObject.name);
        }
        
        if(gameObject.name == "Chocolat")
        {
            Debug.Log(gameObject.name);
        }
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Barman : MonoBehaviour
{
    public Camera mainCamera;

    public void Update()
    {
        Ray ray = mainCamera.ScreenPointToRay(Input.mousePosition);
        RaycastHit hit;

        if (Physics.Raycast(ray, out hit))
        {
            TouchSomething(hit.transform.gameObject);
        }
    }

    public void TouchSomething(GameObject gameObject)
    {
        if (gameObject.name == "Coffee")
        {
            Debug.Log(gameObject.name);
        }

        if (gameObject.name == "Tea")
        {
            Debug.Log(gameObject.name);
        }

        if (gameObject.name == "Chocolat")
        {
            Debug.Log(gameObject.name);
        }
    }
}

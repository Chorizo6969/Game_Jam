using UnityEngine;
using System.Collections;

public class Raycast : MonoBehaviour
{
    public Camera mainCamera; // Référence à la caméra

    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            Ray ray = mainCamera.ScreenPointToRay(Input.mousePosition);
            RaycastHit hit;

            if (Physics.Raycast(ray, out hit))
            {
                if (hit.transform.gameObject == this.gameObject)
                {
                    Debug.Log("Monday my heart is broken");
                }
            }
        }
    }
}
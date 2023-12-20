using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GiveDrink : MonoBehaviour
{
    public List<GameObject> tableList;

    public void OnTriggerEnter(Collider collider)
    {
        if (BarManager.Instance.drink)
        {
            for (int i = 0; i < tableList.Count; i++)
            {
                if (collider.name == tableList[i].name)
                {
                    if (gameObject.tag == "coffee")
                    {
                        collider.gameObject.transform.GetChild(0).gameObject.SetActive(true);
                    }

                    if (gameObject.tag == "tea")
                    {
                        collider.gameObject.transform.GetChild(1).gameObject.SetActive(true);
                    }
                    break;
                }
            }
        }

    }
}

using System.Collections;
using UnityEngine;

public class CoffeeRequest : MonoBehaviour
{
    public void OnTriggerEnter(Collider collider)
    {
        if (BarManager.Instance.drink)
        {
            BarManager.Instance.drink = false;
            StartCoroutine(Drink());
        }
    }
    IEnumerator Drink()
    {
        yield return new WaitForSeconds(3);
        Destroy(this.gameObject);
    }
}

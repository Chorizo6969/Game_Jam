using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HaveADrink : Interactable
{
    protected override void Interact()
    {
        BarManager.Instance.drink = true;
        Debug.Log(this.gameObject);

        if (this.gameObject.tag == "coffee" && gameObject.tag == "coffee")
        {
            BarManager.Instance.HappyClient();
            Debug.Log("caf� donner");

        }

        if (this.gameObject.tag == "tea" && gameObject.tag == "tea")
        {
            BarManager.Instance.HappyClient();
            Debug.Log("th� donner");
        }

        else
        {
            BarManager.Instance.AngryClient();
            Debug.Log("boissoon donner");
        }

        StartCoroutine(Drink());
    }
    IEnumerator Drink()
    {
        yield return new WaitForSeconds(3);
        Destroy(this.gameObject);
    }
}

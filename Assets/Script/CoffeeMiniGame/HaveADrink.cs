using System.Collections;
using UnityEngine;

public class HaveADrink : Interactable
{
    protected override void Interact()
    {
        BarManager.Instance.drink = true;

        if (BarManager.Instance.player.tag == "coffee" && gameObject.tag == "coffee")
        {
            BarManager.Instance.HappyClient();
            Debug.Log("café donner");
        }

        if (BarManager.Instance.player.tag == "tea" && gameObject.tag == "tea")
        {
            BarManager.Instance.HappyClient();
            Debug.Log("thé donner");
        }

        if(BarManager.Instance.player.tag == "tea" && gameObject.tag == "coffee") //une else fait bug
        {
            BarManager.Instance.AngryClient();
            Debug.Log("boissoon donner");
        }
        
        if(BarManager.Instance.player.tag == "coffee" && gameObject.tag == "tea") //une else fait bug
        {
            BarManager.Instance.AngryClient();
            Debug.Log("boissoon donner");
        }

        gameObject.tag = "Untagged";
        BarManager.Instance.handFull = false;

        StartCoroutine(Drink());
    }
    IEnumerator Drink()
    {
        promptMessage = " ";
        yield return new WaitForSeconds(3);
        Destroy(gameObject);
    }
}

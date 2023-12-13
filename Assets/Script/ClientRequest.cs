using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class ClientRequest : MonoBehaviour
{
    public bool iWantCoffee;
    public bool iWantTea;
    public bool iWantChocolat;

    //public GameObject coffeeSprite;
    //public GameObject teaSprite;
    //public GameObject chocolatSprite;

    public void Start()
    {
        int randomRequest = Random.Range(0, 30);

        if (randomRequest <= 10)
        {
            GiveMeCoffee();
        }

        if (randomRequest <= 20 && randomRequest > 10)
        {
            GiveMeTea();
        }

        if (randomRequest > 20)
        {
            GiveMeChocolat();
        }
    }
    public void GiveMeCoffee()
    {
        iWantCoffee = true;
        //coffeeSprite.SetActive(true);
        StartCoroutine(WaitRequest());
    }

    public void GiveMeTea()
    {
        iWantTea = true;
        //teaSprite.SetActive(true);
        StartCoroutine(WaitRequest());
    }

    public void GiveMeChocolat()
    {
        iWantChocolat = true;
        //chocolatSprite.SetActive(true);
        StartCoroutine(WaitRequest());
    }

    public void IHaveSomething()
    {
        iWantCoffee = false;
        BarManager.Instance.HappyClient();
    }
    IEnumerator WaitRequest()
    {
       yield return new WaitForSeconds(2);
        //BarManager.Instance.TimeTooLong();
    }
}

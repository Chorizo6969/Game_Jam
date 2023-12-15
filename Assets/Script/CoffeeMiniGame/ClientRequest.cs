using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class ClientRequest : MonoBehaviour
{ 
    //public GameObject coffeeSprite;
    //public GameObject teaSprite;
    //public GameObject chocolatSprite;

    public void Start()
    {
        int randomRequest = Random.Range(0, 30);

        if (randomRequest <= 10)
        {
            //coffeeSprite.SetActive(true);
            this.AddComponent<CoffeeRequest>();
        }

        if (randomRequest <= 20 && randomRequest > 10)
        {
            //teaSprite.SetActive(true);
            this.AddComponent<TeaRequest>();
        }

        if (randomRequest > 20)
        {
            //chocolatSprite.SetActive(true);
            this.AddComponent<ChocolatRequest>();
        }

        StartCoroutine(WaitRequest());
    }

    IEnumerator WaitRequest()
    {
        yield return new WaitForSeconds(2);
        BarManager.Instance.TimeTooLong();
    }
}

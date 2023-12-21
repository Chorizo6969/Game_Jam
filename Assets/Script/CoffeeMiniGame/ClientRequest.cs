using System.Collections;
using Unity.VisualScripting;
using UnityEngine;

public class ClientRequest : MonoBehaviour
{ 
    public void Start()
    {
        int randomRequest = Random.Range(0, 30);

        if (randomRequest <= 15)
        {
            this.transform.GetChild(0).gameObject.SetActive(true);
            this.gameObject.tag = "coffee";
            //this.AddComponent<CoffeeRequest>();
        }

        else
        {
            this.transform.GetChild(1).gameObject.SetActive(true);
            this.gameObject.tag = "tea";
            //this.AddComponent<TeaRequest>();
        }

        //if (randomRequest > 20)
        //{
        //    chocolatSprite.SetActive(true);
        //    this.AddComponent<ChocolatRequest>();
        //}

        StartCoroutine(WaitRequest());
    }

    IEnumerator WaitRequest()
    {
        yield return new WaitForSeconds(50);
        BarManager.Instance.AngryClient();
    }
}

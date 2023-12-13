using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ClientGenerator : MonoBehaviour
{
    private static ClientGenerator _instance;
    public static ClientGenerator Instance
    {
        get
        {
            if (_instance == null)
            {
                Debug.Log("ClientGenerator is null");
            }
            return _instance;
        }
    }
    public void Awake() 
    {
        _instance = this;
    }

    public GameObject clientPrefab;

    public List<GameObject> clientPostionList;
    public void RandomPosition()  
    {
        int randomClient = Random.Range(0, clientPostionList.Count); //chiffre random entre 0 et le nombre d'élément de la liste de position de client
        Vector3 randomPos = clientPostionList[randomClient].transform.position;
        clientPrefab.transform.position = randomPos;
    }

    public void CreateClient() //création client
    {
        GameObject newClient = Instantiate(clientPrefab);
        newClient.GetComponent<ClientRequest>();
        RandomPosition();
        StartCoroutine(WaitForNewClient());
    }

    IEnumerator WaitForNewClient()
    {
        yield return new WaitForSeconds(5);
        CreateClient();
    }
}

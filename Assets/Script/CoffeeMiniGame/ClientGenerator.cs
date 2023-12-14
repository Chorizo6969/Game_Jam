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

    public List<GameObject> clientPositionList;

    [SerializeField] private List<GameObject> _positionList;
    public void RandomPosition()
    {
        if (clientPositionList.Count > 0)
        {
            int randomClient = Random.Range(0, clientPositionList.Count); //chiffre random entre 0 et le nombre d'élément de la liste de position de client
            Vector3 randomPos = clientPositionList[randomClient].transform.position;
            clientPositionList.Remove(clientPositionList[randomClient]);
            Debug.Log("remove position");
            clientPrefab.transform.position = randomPos;
        }
        else
        {
            clientPositionList.AddRange(_positionList);
            Debug.Log("add");

        }
    }

    public void CreateClient() //création client
    {
        GameObject newClient = Instantiate(clientPrefab);
        newClient.AddComponent<ClientRequest>();
        RandomPosition();
        StartCoroutine(WaitForNewClient());
    }

    IEnumerator WaitForNewClient()
    {
        yield return new WaitForSeconds(2);
        CreateClient();
    }
}

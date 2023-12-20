using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ForestManager : MonoBehaviour
{
    private static ForestManager _instance;
    public static ForestManager Instance
    {
        get
        {
            if (_instance == null)
            {
                Debug.Log("ForestManager is null");
            }
            return _instance;
        }
    }

    public void Awake()
    {
        _instance = this;
    }

    public int numberObject;

    public GameObject playerInventory;
    public List<GameObject> objectInInventory;

    public List<GameObject> objectPickUp;

    public void Start()
    {
        //this.GetComponentInChildren<Dialogue>().Activate();
        objectPickUp.Clear();

        playerInventory.SetActive(true);
    }
    public void ObjectInHisPlace()
    {
        numberObject++;
    }
}
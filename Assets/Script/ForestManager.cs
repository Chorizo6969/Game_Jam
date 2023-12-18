using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

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

    public void Start()
    {
        this.GetComponentInChildren<Dialogue>().Activate();
    }
    public void ObjectInHisPlace()
    {
        numberObject++;
    }

}
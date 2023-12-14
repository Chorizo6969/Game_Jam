using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BarManager : MonoBehaviour
{
    private static BarManager _instance;
    public static BarManager Instance
    {
        get
        {
            if (_instance == null)
            {
                Debug.Log("BarManager is null");
            }
            return _instance;
        }
    }
    public void Awake()
    {
        _instance = this;
    }

    public int satifactionClient;
    public bool clientGoAway;

    public void Start()
    {
        ClientGenerator.Instance.CreateClient();
    }
    public void TimeTooLong()
    {
        satifactionClient--;
        Debug.Log("angryClient");
        clientGoAway = true;
    }
    public void HappyClient()
    {
        satifactionClient++;
        clientGoAway = true;
        Debug.Log("happyClient");

    }
}

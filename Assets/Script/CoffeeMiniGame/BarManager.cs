using TMPro;
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

    public TextMeshProUGUI satisfactionText;

    public int satisfactionClient;

    public void Start()
    {
        ClientGenerator.Instance.CreateClient();
    }
    public void AngryClient()
    {
        satisfactionClient--;
        UpdateText();
    }
    public void HappyClient()
    {
        satisfactionClient++;
        UpdateText();
    }

    public void UpdateText()
    {
        satisfactionText.text = "Satisfaction client : " + satisfactionClient.ToString();
    }
}

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

    public bool drink;

    public GameObject player;
    public GameObject canvasCoffeeGame;

    public int numberOfDrink;
    public Animator animator;
    public bool handFull;

    public void Start()
    {
        canvasCoffeeGame.SetActive(true);
        ClientGenerator.Instance.CreateClient();
    }
    public void AngryClient()
    {
        satisfactionClient--;
        UpdateText();
        NumberOfDrink();
        drink = false;
        Debug.Log(drink);
    }
    public void HappyClient()
    {
        satisfactionClient++;
        UpdateText();
        NumberOfDrink();
        drink = false;
        Debug.Log(drink);
    }

    public void UpdateText()
    {
        satisfactionText.text = "Satisfaction client : " + satisfactionClient.ToString();
    }
    public void NumberOfDrink()
    {
        numberOfDrink++;

        if(numberOfDrink >= 15)
        {
            CanEscapeTheCoffee();
        }
    }

    public void CanEscapeTheCoffee()
    {
        animator.SetBool("DoorCanOpen", true);
    }
}

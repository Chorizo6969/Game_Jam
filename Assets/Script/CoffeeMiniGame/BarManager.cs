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

    public GameObject dialogue2;
    public GameObject dialogue3;
    public GameObject dialogue4;
    public GameObject dialogue5;
    public GameObject dialogue6;
    public GameObject dialogue7;

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
        //Debug.Log(drink);
    }
    public void HappyClient()
    {
        satisfactionClient++;
        UpdateText();
        NumberOfDrink();
        drink = false;
        //Debug.Log(drink);
    }

    public void UpdateText()
    {
        satisfactionText.text = "Satisfaction client : " + satisfactionClient.ToString();
    }
    public void NumberOfDrink()
    {
        numberOfDrink++;

        if (numberOfDrink == 3)
        {
            dialogue2.GetComponent<Dialogue>().Activate();
        }
        if (numberOfDrink == 5)
        {
            dialogue3.GetComponent<Dialogue>().Activate();
        }
        if (numberOfDrink == 8)
        {
            dialogue4.GetComponent<Dialogue>().Activate();
        }
        if (numberOfDrink == 10)
        {
            dialogue5.GetComponent<Dialogue>().Activate();
        }
        if (numberOfDrink == 12)
        {
            dialogue6.GetComponent<Dialogue>().Activate();
        }

        if(numberOfDrink >= 15)
        {
            CanEscapeTheCoffee();
        }
    }

    public void CanEscapeTheCoffee()
    {
        animator.SetBool("DoorCanOpen", true);
        dialogue7.GetComponent<Dialogue>().Activate();
    }
}

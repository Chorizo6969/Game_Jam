using UnityEngine;

public class HotelManager : MonoBehaviour
{
    public bool canMove;

    private static HotelManager _instance;
    public static HotelManager Instance
    {
        get
        {
            if (_instance == null)
            {
                Debug.Log("NomScript is null");
            }
            return _instance;
        }
    }
    public void Awake()
    {
        _instance = this;
    }

    // Start is called before the first frame update
    void Start()
    {
        // ajouté animation tremblement de terre
        this.GetComponentInChildren<Dialogue>().Activate();
        canMove = true;
    }
}

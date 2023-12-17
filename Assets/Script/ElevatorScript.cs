using UnityEngine;
using UnityEngine.SceneManagement;

public class ElevatorScript : MonoBehaviour
{
    public string NextLevel;
    public GameObject scene1;
    public GameObject scene2;

    private void OnTriggerEnter(Collider other)
    {
        //SceneManager.LoadScene(NextLevel);
        scene1.SetActive(false);
        scene2.SetActive(true);

    }
}

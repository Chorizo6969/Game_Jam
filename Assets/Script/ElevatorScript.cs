using UnityEngine;
using UnityEngine.SceneManagement;

public class ElevatorScript : MonoBehaviour
{
    public string NextLevel;

    private void OnTriggerEnter(Collider other)
    {
        SceneManager.LoadScene(NextLevel);
    }
}

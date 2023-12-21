using UnityEngine;
using UnityEngine.SceneManagement;
using System.Collections;

public class ChangeScene : MonoBehaviour
{
    public string sceneName;

    public void LoadScene()
    {
        SceneManager.LoadScene(sceneName);
    }
    public void QuitGame()
    {
        Application.Quit();
    }
    public void CreditsScene()
    {
        StartCoroutine(SpawnDelay());
    }
    IEnumerator SpawnDelay()
    {
        yield return new WaitForSeconds(1);
        SceneManager.LoadScene("Credits");
    }
    public void MainMenueScene()
    {
        SceneManager.LoadScene("MainMenu");
    }
}

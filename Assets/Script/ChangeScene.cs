using UnityEngine;
using UnityEngine.SceneManagement;
using System.Collections;

public class ChangeScene : MonoBehaviour
{
    public string sceneName;
    public Animator animator;
    public GameObject fonduAuNoir;

    public void Start()
    {
        Cursor.visible = true;
        Cursor.lockState = CursorLockMode.None;
    }
    public void FonduAuNoir()
    {
        fonduAuNoir.SetActive(true);
        animator.SetBool("Play", true);
        StartCoroutine(waitFonduAuNoir());

    }
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

    IEnumerator waitFonduAuNoir()
    {
        yield return new WaitForSeconds(2);
        SceneManager.LoadScene(sceneName);
    }
}

//Script enfant de Interacable (et non de MonoBehaviour)
using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class Door_Close_Anim : Interactable
{
    public GameObject GO;
    public Animator anim;
    protected override void Interact()//Cette fct Interact permet de lancer la fermeture (et donc l'animation) de la porte
    {
        Debug.Log("test");//test
        anim.SetBool("Click", false); //Permet cette fois de remplir la condition pour lancer l'animation dans l'Animator
        StartCoroutine(SpawnDelay());
    }
    
    IEnumerator SpawnDelay()
    {
        yield return new WaitForSeconds(6);
        SceneManager.LoadScene("ProtoSceneForet");
    }
}

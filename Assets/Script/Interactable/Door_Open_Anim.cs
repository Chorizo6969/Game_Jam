//Script enfant de Interacable (et non de MonoBehaviour)
using UnityEngine;

public class Door_Open_Anim : Interactable
{
    public GameObject GO;
    public Animator anim;
    public GameObject Audio;
    public GameObject Elevator_Song;
    protected override void Interact()//Cette fct Interact permet de lancer l'ouverture (et donc l'animation) de la porte
    {
        Debug.Log("test"); //test
        Audio.SetActive(false);
        Elevator_Song.SetActive(true);
        anim.SetBool("Click", true);//remplit la condition pour pouvoir démarrer l'animation dans Animator
        this.GetComponent<Dialogue>().Activate();
    }
}

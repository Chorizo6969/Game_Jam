//Script enfant de Interacable (et non de MonoBehaviour)
using UnityEngine;

public class Musics : Interactable
{
    public AudioSource _audiosource;
    protected override void Interact()//Cette fct Interact permet de lancer l'ouverture (et donc l'animation) de la porte
    {
        _audiosource.Play();
    }
}


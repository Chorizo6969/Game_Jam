//Script enfant de Interacable (et non de MonoBehaviour)
using UnityEngine;

public class Music : MonoBehaviour
{
    public AudioSource audioSource;
    public AudioClip interactionSound;
    public void PlayMusic()//Cette fct Interact permet de gerer l'interaction lorsque l'on appuie sur E
    {
        if (audioSource != null && interactionSound != null)
        {
            audioSource.clip = interactionSound;
            audioSource.Play();
            gameObject.SetActive(false);
        }
    }
}

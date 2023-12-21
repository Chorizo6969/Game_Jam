using UnityEngine;

public class CursorSong : MonoBehaviour
{
    public AudioClip pop;

    private AudioSource audiosource;
    void Start()
    {
        audiosource = GetComponent<AudioSource>();
        audiosource.clip = pop;
        audiosource.playOnAwake = false;
    }

    public void OnPointerEnter()
    {
        Debug.Log("Dino");
        audiosource.Play();
    }
}

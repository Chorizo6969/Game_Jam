using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Animation : Interactable
{
    public GameObject GO;
    private GameObject door;
    private bool doorOpen;

    protected override void Interact()
    {
        doorOpen = !doorOpen;
        door.GetComponent<Animator>().SetBool("isOpen", doorOpen);
        Debug.Log("Tu as collecté : " + gameObject.name);
    }
}

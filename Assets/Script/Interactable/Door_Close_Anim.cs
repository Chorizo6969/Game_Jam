using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Door_Close_Anim : Interactable
{
    public GameObject GO;
    private GameObject door;
    public Animator anim;

    protected override void Interact()
    {
        Debug.Log("test");
        anim.SetBool("Click", false);
    }
}

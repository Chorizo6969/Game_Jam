using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;


public class Cube : Interactable
{
    public GameObject GO;

    protected override void Interact()
    {
        Destroy(GO);
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Porte : Interactable
{
    protected override void Interact()
    {
        Debug.Log("Tu as collecté : " + gameObject.name);
    }
}

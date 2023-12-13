using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class Dialogue : MonoBehaviour
{
    public TMP_Text monTexte;
    public float Delay;
    public List<string> dialogueList;
    public GameObject fauxPanel;
    public bool Detruire = true;
    public GameObject Roger;

    Coroutine maCoroutine;

    private int Compte = 0;
    private string current;

    bool isPressed;

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Mouse0))
        {
            if (isPressed)
            {
                ModifierTexte();
                AfficheTexte();
            }
        }

        if (Input.GetKeyDown(KeyCode.Mouse1))
        {
            if (maCoroutine != null)
            {
                StopCoroutine(maCoroutine);
            }
            monTexte.maxVisibleCharacters = monTexte.text.Length;
        }
    }

    public void Activate()
    {
        isPressed = true;
        current = (dialogueList[Compte]);
        Compte++;
        AfficheTexte();
    }

    private void ModifierTexte()
    {
        if (Compte > dialogueList.Count)
        {
            Debug.Log("liste finie");
        }
        if (Compte == dialogueList.Count)
        {
            current = "";
            fauxPanel.SetActive(false);
            isPressed = false;
            Compte = 0;
            if (Detruire)
            {
                Destroy(Roger);
            }
        }
        else
        {
            current = (dialogueList[Compte]);
            Compte++;
        }
    }

    public void AfficheTexte()
    {

        monTexte.text = current;
        monTexte.maxVisibleCharacters = 0;
        maCoroutine = StartCoroutine(TexteLettreParLettre());
    }

    /*IEnumerator Attente(float delai)
    {
        yield return new WaitForSeconds(delai);
    }*/

    public void OnDisable()
    {
        monTexte.text = null;
    }

    IEnumerator TexteLettreParLettre()
    {
        for (int i = 0; i <= monTexte.text.Length; i++)
        {
            monTexte.maxVisibleCharacters++;
            yield return new WaitForSeconds(Delay);
        }
    }
}

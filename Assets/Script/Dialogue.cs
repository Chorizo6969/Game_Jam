using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Dialogue : MonoBehaviour
{
    public TMP_Text monTexte;
    public float Delay;
    public List<string> dialogueList;
    public GameObject fauxPanel;
    public bool Detruire = false;
    public GameObject Roger;

    Coroutine maCoroutine;

    private int Compte = 0;
    private string current;

    bool isPressed;
    public bool canMove = false;

    private static Dialogue _instance;
    public static Dialogue Instance
    {
        get
        {
            if (_instance == null)
            {
                Debug.Log("NomScript is null");
            }
            return _instance;
        }
    }
    public void Awake()
    {
        _instance = this;
    }

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
        fauxPanel.SetActive(true);
        isPressed = true;
        current = (dialogueList[0]);
        AfficheTexte();
    }

    private void ModifierTexte()
    {
        if (Compte > dialogueList.Count)
        {
            Debug.Log("liste finie");
            canMove = true;
        }
        if (Compte == dialogueList.Count)
        {
            current = "";
            fauxPanel.SetActive(false);
            isPressed = false;
            Compte = 0;
            //canMove = true;
            Debug.Log(canMove);
            Destroy(Roger);
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

    public void OnDisable()
    {
        monTexte.text = null;
        canMove = true;
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

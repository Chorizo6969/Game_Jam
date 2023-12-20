using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;

public class Player_Ui : MonoBehaviour
{
    [SerializeField] //permet de voir dans l'inspecteur le champ promptText et de le remplir (malgr� le fait qu'il soit priv�)
    private TextMeshProUGUI promptText; //Affiche le message de ce qu'est l'objet (ex: "E" Ours en peluche)
    public void UpdateText(string promptMessage)
    {
        promptText.text = promptMessage;
    }
}

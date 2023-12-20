using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;

public class Player_Ui : MonoBehaviour
{
    [SerializeField] //permet de voir dans l'inspecteur le champ promptText et de le remplir (malgré le fait qu'il soit privé)
    private TextMeshProUGUI promptText; //Affiche le message de ce qu'est l'objet (ex: "E" Ours en peluche)
    public void UpdateText(string promptMessage)
    {
        promptText.text = promptMessage;
    }
}

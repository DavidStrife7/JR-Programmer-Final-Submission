using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TextUpdate : MonoBehaviour
{
    private Text welcomeText;
    private GameManager GM;
    // Start is called before the first frame update
    void Start()
    {
        welcomeText = GetComponent<Text>();
        GM = GameManager.GMInstance;
        UpdatePlayerName();
    }

    private void UpdatePlayerName() // ABSTRACTION
    {
        welcomeText.text = "Welcome " + GM.playerName + "!";
    }
}

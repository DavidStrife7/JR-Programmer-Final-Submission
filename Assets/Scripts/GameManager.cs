using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    public InputField playerNameInputField;
    public static GameManager GMInstance { get; private set; } // ENCAPSULATION

    public string playerName = "No Name";
    private void Awake()
    {
        if (GMInstance != null)
        {
            Destroy(gameObject);
            return;
        }

        GMInstance = this;
        DontDestroyOnLoad(this);
    }

    public void SetPlayerName() // ABSTRACTION
    {
        if (playerNameInputField.text != "")
        {
            playerName = playerNameInputField.text;
            return;
        }
        else
        {
            playerName = "Bob";
        }
    }
}

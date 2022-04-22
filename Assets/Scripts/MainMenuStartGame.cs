using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenuStartGame : MonoBehaviour
{
    private GameManager GM;
    private void Start()
    {
        GM = GameManager.GMInstance;
    }

    public void StartGame()
    {
        GM.SetPlayerName();
    }
}

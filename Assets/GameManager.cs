using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    private static GameManager GMInstance;

    private void Awake()
    {
        if (GMInstance != null)
        {
            return;
        }

        GMInstance = this;
        DontDestroyOnLoad(this);
    }
}

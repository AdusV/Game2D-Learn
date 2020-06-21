using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManagerTransmitter : MonoBehaviour
{
    public void OpenCurrentLevel()
    {
       GameManager.instance.OpenLevel(GameManager.instance.currentLevel);
    }
    public void CloseApplication()
    {
        PlayerPrefs.SetInt("currentLevel",GameManager.instance.currentLevel);

        Application.Quit();
    }
}

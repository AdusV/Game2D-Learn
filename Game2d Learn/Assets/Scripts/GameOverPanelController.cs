using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameOverPanelController : MonoBehaviour
{
    public void LoadLevelAgain()
    {
        GameManager.instance.OpenLevel(GameManager.instance.currentLevel);
    }
    public void LoadNextLevel()
    {
        GameManager.instance.currentLevel++;
        if (GameManager.instance.currentLevel<GameManager.instance.levelNames.Length)
        {
            GameManager.instance.OpenLevel(GameManager.instance.currentLevel);
        }
        else
        {
            GameManager.instance.currentLevel = 0;
            GameManager.instance.OpenLevel(GameManager.instance.currentLevel);
        }
        
    }
    public void LoadMenu()
    {
        SceneManager.LoadScene(0);
    }

}

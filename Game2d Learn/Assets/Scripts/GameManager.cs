using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public static GameManager instance = null;
    public int currentLevel = 0;
    //Tworzenie tablicy Poziomow 
    public string[] levelNames;

    private void Awake()
    {
        if (instance == null)
        {
            instance = this;
        }
        else if(instance != this)
        {
            Destroy(this.gameObject);
        }

        DontDestroyOnLoad(this.gameObject);
    }

    private void Start()
    {
        if(PlayerPrefs.HasKey("currentLevel"))
        {
           currentLevel = PlayerPrefs.GetInt("currentLevel");
        }
        
    }
    public void OpenLevel(int newLevelNum)
    {
        SceneManager.LoadScene(levelNames[newLevelNum]);
    }
    public void OpenCurrentLevel()
    {
        OpenLevel(currentLevel); 
    }
    public void CloseApplication()
    {
        PlayerPrefs.SetInt("currentLevel", currentLevel);
        
        Application.Quit();
    }
}

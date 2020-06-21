﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameOverControl : MonoBehaviour
{
    GameObject successPanel;
    GameObject failPanel;
    GameObject gameOverCanvas;
    private void Start()
    {
        Time.timeScale = 1;
        gameOverCanvas = GameObject.Find("GameOverCanvas");
        if(gameOverCanvas != null)
        {
            failPanel = gameOverCanvas.transform.GetChild(0).gameObject;
            successPanel = gameOverCanvas.transform.GetChild(1).gameObject;
        }
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.gameObject.tag == "baloon")
        {
            Debug.Log("Sukces");
            successPanel.SetActive(true);
            Time.timeScale = 0; 
        }
        else if(collision.gameObject.tag == "border")
        {
            Debug.Log("Failuer");
            failPanel.SetActive(true);
            Time.timeScale = 0;
        }
    }
}

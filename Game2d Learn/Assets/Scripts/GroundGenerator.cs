﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GroundGenerator : MonoBehaviour
{
    public GameObject[] groundPrefabs;
    public float maxStep;
    private float previousGroundY = -2.5f;
    public float maxHeight;
    public float minHeight;
    

    private void Start()
    {
        InvokeRepeating("GenerateNewGround", 0, 2); 
    }
    void GenerateNewGround()
       
    {
        float newY;
        //Wykonujemy do dopoki loswanie jest mniejsze jak poprzednie generoowanie
        do
        {
             newY = Random.Range(minHeight, maxHeight);
        } while (newY > maxStep + previousGroundY);
        
        
        Vector3 targetPrefabPosition = new Vector3(this.transform.position.x, newY, this.transform.position.z);
        //poprzedni czyli pierwszy generowany ground  jest wyzej jak nastepny , czyli nowy jest nizej
        previousGroundY = targetPrefabPosition.y;
        Instantiate(groundPrefabs[Random.Range(0, groundPrefabs.Length)], targetPrefabPosition, Quaternion.identity);
    }
}   

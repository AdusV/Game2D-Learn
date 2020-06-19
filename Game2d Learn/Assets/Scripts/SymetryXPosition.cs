using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SymetryXPosition : MonoBehaviour
{
    public GameObject hero;

    Vector3 currentPosition;
    Vector3 targetPosition;

    float startTime;
    private float currentTime;
    public float randomYMax;
    public float randomYMin;

    private void Start()
    {
        startTime = Time.time;
        InvokeRepeating("SetNewPositions", 0, 1);
    }
    private void Update()
    {
        currentTime = Time.time - startTime;
        transform.position = Vector3.Slerp(currentPosition, targetPosition, currentTime);
       
    }
    void SetNewPositions()
    {
        currentPosition = transform.position;
        targetPosition = new Vector3(Mathf.Abs(hero.transform.position.x), Random.Range(randomYMin,randomYMax), transform.position.z);
        startTime = Time.time;
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CloseEndEscape : MonoBehaviour
{
    void Update()
    {
        if(Input.GetKey(KeyCode.Escape))
        {
            GameManager.instance.CloseApplication();
        }
    }
}

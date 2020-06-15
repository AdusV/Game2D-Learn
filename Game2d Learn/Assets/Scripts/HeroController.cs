using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HeroController : MonoBehaviour
{
    Animator anim;
    Rigidbody2D body;
    public float jumpForce;

    private void Start()
    {
        anim = GetComponent<Animator>();
        body = GetComponent<Rigidbody2D>();
    }
    private void Update()
    {//Lewy przycisk myszy 
        if (Input.GetMouseButtonDown(0))
        {
            anim.SetTrigger("Jump");
            //ForceMode2D.Impulse jednorazowe wystrzelenie w klatce
            body.AddForce(Vector2.up * jumpForce, ForceMode2D.Impulse);
        }
    }
}

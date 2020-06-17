using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HeroController : MonoBehaviour
{
    Animator anim;
    Rigidbody2D body;
    public float jumpForce;
    private bool isGrounded;

    private void Start()
    {
        anim = GetComponent<Animator>();
        body = GetComponent<Rigidbody2D>();
    }
    private void Update()
    {//Lewy przycisk myszy 
        if (Input.GetMouseButtonDown(0) && isGrounded)
        {
            anim.SetTrigger("Jump");
            //ForceMode2D.Impulse jednorazowe wystrzelenie w klatce
            body.AddForce(Vector2.up * jumpForce, ForceMode2D.Impulse);
        }
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Ground") 
        {
            isGrounded = true;
        }
    }
    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.tag == "Ground")
        {
            isGrounded = false;
        }
    }
}

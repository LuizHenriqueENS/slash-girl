using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class JogadorCombate : MonoBehaviour
{
    Rigidbody2D rb;
    Animator animator;


    
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        animator = GetComponent<Animator>();
    }


    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            Debug.Log("Atacar");
            animator.SetTrigger("Ataque");
        }


    }
    private void FixedUpdate()
    {
    }
}

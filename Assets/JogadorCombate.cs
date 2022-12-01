using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class JogadorCombate : MonoBehaviour
{
    Animator animator;
    void Start()
    {
        animator = GetComponent<Animator>();
    }

    
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Space)){
            Debug.Log("Atacar");
            animator.SetTrigger("Ataque");
        }
    }
}

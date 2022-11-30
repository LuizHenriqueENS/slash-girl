using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class JogadorMovimento : MonoBehaviour
{

    Rigidbody2D rb;


    //animação
    Animator animator;

    //movimentação
    [SerializeField] float velocidadeDoMovimento = 100f;
    float movimentacaoHorizontal;
    bool m_FacingRight = false;

    private void Awake()
    {
        Application.targetFrameRate = -1;
    }

    void Start()
    {
        animator = GetComponent<Animator>();
        rb = GetComponent<Rigidbody2D>();
    }


    void Update()
    {
        MovimentarJogador();

        animator.SetFloat("Correr", Mathf.Abs(movimentacaoHorizontal));


    }


    private void FixedUpdate()
    {
        rb.velocity = new Vector2(movimentacaoHorizontal * Time.fixedDeltaTime, rb.velocity.y);

    }


    private void MovimentarJogador()
    {
        movimentacaoHorizontal = Input.GetAxisRaw("Horizontal") * velocidadeDoMovimento;
        if (movimentacaoHorizontal > 0 && !m_FacingRight)
        {
            Flip();
        }
        else if (movimentacaoHorizontal < 0 && m_FacingRight)
        {
            Flip();
        }
    }

    private void Flip()
    {
        // Switch the way the player is labelled as facing.
        m_FacingRight = !m_FacingRight;

        // Multiply the player's x local scale by -1.
        Vector3 theScale = transform.localScale;
        theScale.x *= -1;
        transform.localScale = theScale;
    }

    public float velocidadeAtual()
    {
        return movimentacaoHorizontal;
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MovimentoPerso : MonoBehaviour
{
    Rigidbody2D rb;
    [SerializeField] [Range(0, 15)] float velocidade = 8;
    [SerializeField] float velocidadePulo = 5;
    Vector2 velocidadeFinal;
    float moverHorizontal;
    bool pediuPraPular;
    Animator anim;

    [SerializeField] LayerMask layerPiso;
    [SerializeField] Transform pontoInicialPiso;
    [SerializeField] Transform pontoFinalPiso;
    RaycastHit2D hit;
    bool estaPulando;

    private void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        anim = GetComponent<Animator>();
    }

    private void Update()
    {
        LeInput();
        CalculaVelocidade();
    }

    private void FixedUpdate()
    {
        Velocidade();
        EstaNoChao();   
    }

    private void LateUpdate()
    {
        Animacoes();
    }

    void LeInput()
    {
        moverHorizontal = Input.GetAxis("Horizontal");
        pediuPraPular = Input.GetButtonDown("Jump");
    }

    void Velocidade()
    {
        rb.velocity = velocidadeFinal;
    }

    void CalculaVelocidade()
    {
        velocidadeFinal.x = moverHorizontal * velocidade;

        if (pediuPraPular)
        {

            velocidadeFinal.y = velocidadePulo;
        }
        else
        {
            velocidadeFinal.y = rb.velocity.y;
        }
    }

    void Animacoes()
    {
        anim.SetFloat("Speed", Mathf.Abs(velocidadeFinal.x));
        anim.SetBool("Pulou", estaPulando);
    }

    void EstaNoChao()
    {
       hit = Physics2D.Linecast(pontoInicialPiso.position, pontoFinalPiso.position, layerPiso);
       estaPulando = hit.collider == null;
    }
}

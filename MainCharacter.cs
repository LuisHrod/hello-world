using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MainCharacter : MonoBehaviour
{
    public int vida;
    public float moverHorizontal;
    public float moverVertical;
    private Vector2 mover;
    public Rigidbody2D rb2d;
    public float velocidade;
    private bool atacar;
    public 


    // Start is called before the first frame update
    void Start()
    {
        vida = 100;
        velocidade = 4;
        rb2d = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            vida = vida - 1;
            //vida--;
            Debug.Log("Tecla de espaço pressionada. (Vida = " + vida + ")");
           // GetComponent<AudioSource>().Play();
            GetComponent<Rigidbody2D>().AddForce(new Vector2(0, 700));

        }

        // Mover
        // Edit / Project Settings / Input
        float moverHorizontal = Input.GetAxis("Horizontal");

        if (moverHorizontal != 0)
        {
            rb2d.velocity = new Vector2(moverHorizontal * velocidade, rb2d.velocity.y);
            GetComponent<Animator>().SetBool("Parado", false);
        }
        else
        {
            GetComponent<Animator>().SetBool("Parado", true);
        }

        // Atacar
       // bool atacar = Input.GetMouseButtonDown("MouseX");
        if (atacar = true)
        {
            GetComponent<Animator>().SetBool("Atacando", true);

        }
        else
        {
            GetComponent<Animator>().SetBool("Atacando", false);
        }

        //Rotacionar personagem
        if (moverHorizontal < 0)
        {
            GetComponent<SpriteRenderer>().flipX = true;
        }
        if (moverHorizontal > 0)
        {
            GetComponent<SpriteRenderer>().flipX = false;
            // GetComponent<AudioSource>().Play();

        }

    }

    void FixedUpdate()
    {

    }
}

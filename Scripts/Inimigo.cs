using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Inimigo : MonoBehaviour
{
    public int vida;
    public float moverHorizontal;
    public float moverVertical;
    private Vector2 mover;
    public Rigidbody2D rb2d;
    public float velocidade;

    // Start is called before the first frame update
    void Start()
    {
        vida = 50;
        velocidade = 1;
        rb2d = GetComponent<Rigidbody2D>();

    }

    // Update is called once per frame
    void Update()
    {
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

        if (moverHorizontal < 0)
        {
            GetComponent<SpriteRenderer>().flipX = false;
        }
        if (moverHorizontal > 0)
        {
            GetComponent<SpriteRenderer>().flipX = true;
        }
    }
}

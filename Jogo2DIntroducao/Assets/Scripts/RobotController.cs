using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RobotController : MonoBehaviour
{
    [HideInInspector] public bool viradoDireita = true;

    public float forcaMovimento = 365f;
    public float velocidadeMaxima = 5f;

    private float h;
    private Animator anim;
    private Rigidbody2D rb2d;

    // Start is called before the first frame update
    void Start()
    {
        anim = GetComponent<Animator>();
        rb2d = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        h = Input.GetAxis("Horizontal");

        rb2d.AddForce(new Vector2(h * velocidadeMaxima, rb2d.velocity.y));
        //rb2d.velocity = new Vector2(h * velocidadeMaxima, rb2d.velocity.y);

        anim.SetFloat("Speed", Mathf.Abs(rb2d.velocity.x));

        if (h > 0 && !viradoDireita) Flip();
        else if (h < 0 && viradoDireita) Flip();
    }

    private void Flip()
    {
        viradoDireita = !viradoDireita;
        Vector3 escala = transform.localScale;
        escala.x *= -1;
        transform.localScale = escala;
    }
}

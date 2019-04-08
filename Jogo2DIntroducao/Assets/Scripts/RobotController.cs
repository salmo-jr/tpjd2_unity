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

    // Start is called before the first frame update
    void Start()
    {
        anim = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        h = Input.GetAxis("Horizontal");
        anim.SetFloat("Speed", Mathf.Abs(h));
    }
}

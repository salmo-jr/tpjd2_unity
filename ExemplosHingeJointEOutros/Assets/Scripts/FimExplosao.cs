using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FimExplosao : MonoBehaviour
{
    private Animator anim;
    private float tempoAnimacao;

    // Start is called before the first frame update
    void Start()
    {
        anim = GetComponent<Animator>();
        tempoAnimacao = anim.GetCurrentAnimatorStateInfo(0).length;
        Destroy(this.gameObject, tempoAnimacao);
    }
}

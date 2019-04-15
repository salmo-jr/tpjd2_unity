using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Coletavel : MonoBehaviour
{
    public GameObject obj;
    public float incremento = 1f;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            GameController.instancia.AtualizaPontos(incremento);
            GameController.instancia.obj = obj;
            Destroy(this.gameObject);
        }
    }
}

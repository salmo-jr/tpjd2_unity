using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameController : MonoBehaviour
{
    public static GameController instancia; // PADRAO DE PROJETO SINGLETON
    public Text pontos; 
    public GameObject obj;
    public Transform pos;
    public float coletaveis;

    private void Awake()
    {
        // VERIFICA SE JA EXISTE UMA INSTANCIA
        if (instancia == null)
        {
            // PROSSEGUE COM A INSTANCIA 
            instancia = this;
        }
        else
        {
            if (instancia != this)
            {
                // DESCONSIDERA A SEGUNDA CHAMADA DE CRIACAO
                Destroy(this);
            }
        }

        coletaveis = 0;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetButtonDown("Fire1"))
        {
            Instantiate(obj, pos);
        }
    }

    public void AtualizaPontos(float inc)
    {
        //coletaveis = coletaveis + inc;
        coletaveis += inc;
        pontos.text = "Pontos: " + coletaveis;
    }
}

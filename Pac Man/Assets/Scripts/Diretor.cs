using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Diretor : MonoBehaviour
{
    private static int pontos = 0;

    public int pontosMaximos = 0;

    public void AdicionarPontos()
    {
        pontos++;
    }

    // Start is called before the first frame update

    void Start()
    {
        
    }

    private void Update()
    {
        if (pontos >= pontosMaximos)
        {
            Debug.Log("Ganhou");
            Time.timeScale = 0;
        }
    }

    public void AdicionarPontosMaximo(int numeroDePontos)
    {
        pontosMaximos = numeroDePontos;
    }
}

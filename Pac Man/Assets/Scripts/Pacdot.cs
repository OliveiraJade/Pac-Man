using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pacdot : MonoBehaviour
{
    public Diretor diretor;

    private void Start()
    {
        diretor = GameObject.FindObjectOfType<Diretor>();
    }

    private void OnTriggerEnter2D(Collider2D colisor)
    {
        if(colisor.name == "Pacman")
        {
            diretor.AdicionarPontos();
            Destroy(gameObject);
            
        }    
    }
}

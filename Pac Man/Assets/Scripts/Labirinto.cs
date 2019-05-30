using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Labirinto : MonoBehaviour
{
    public Diretor diretor;

    // Start is called before the first frame update
    void Start()
    {
        diretor = GameObject.FindObjectOfType<Diretor>();
        int total = GameObject.FindGameObjectsWithTag("pontos").Length;
        diretor.AdicionarPontosMaximo(total);
           
            
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}

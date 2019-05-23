using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PacmanMove : MonoBehaviour
{
    public float speed = 0.4f;

    Vector2 dest = Vector2.zero;
    // Start is called before the first frame update
    void Start()
    {
        dest = transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.UpArrow))
        {
            Debug.Log("CIMA");
        }
        else if (Input.GetKey(KeyCode.DownArrow))
        {

            Debug.Log("BAIXO");

        }
        else if (Input.GetKey(KeyCode.LeftArrow))
        {

            Debug.Log("ESQUERDA");

        }
        else if (Input.GetKey(KeyCode.RightArrow))
        {
            Debug.Log("Direita");
        }

    }
} 

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
        float x = 0, y = 0;

        Vector2 posicaoDestino = Vector2.MoveTowards(transform.position, dest, speed);
        GetComponent<Rigidbody2D>().MovePosition(posicaoDestino);

        if (Input.GetKey(KeyCode.UpArrow))
        {
            dest = (Vector2)transform.position + Vector2.up; 
        }
        else if (Input.GetKey(KeyCode.DownArrow))
        {
            dest = (Vector2)transform.position - Vector2.up;

        }
        else if (Input.GetKey(KeyCode.LeftArrow))
        {
            dest = (Vector2)transform.position - Vector2.right;

        }
        else if (Input.GetKey(KeyCode.RightArrow))
        {
            dest = (Vector2)transform.position + Vector2.right;

        }

        Vector2 dir = dest - (Vector2)transform.position;
        GetComponent<Animator>().SetFloat("DirX", dir.x);
        GetComponent<Animator>().SetFloat("DirY", dir.y);
    }
} 

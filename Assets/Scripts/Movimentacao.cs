using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movimentacao : MonoBehaviour
{
    public float velocidade = 0.1f;
    public float forcaPulo = 500f;
    private ForceMode tipoDeForca = ForceMode.Impulse;
    private Rigidbody rb;
    private bool grounded;

    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    void Update()
    {
        if (grounded)
        {
            if (Input.GetKey("space"))
            {
                rb.AddForce(
                    0,
                    velocidade * 200,
                    0,
                    tipoDeForca
                );
            }
        }

            if (Input.GetAxis("Horizontal") > 0)
        {
            rb.AddForce(
                velocidade,
                0,
                0,
                tipoDeForca
            );
        }
        else if (Input.GetAxis("Horizontal") < 0)
        {
            rb.AddForce(
                velocidade * -1f, 
                0, 
                0,
                tipoDeForca
            );
        }
        if (Input.GetAxis("Vertical") > 0)
        {
            rb.AddForce(
                0,
                0,
                velocidade,
                tipoDeForca
            );
        }
        else if (Input.GetAxis("Vertical") < 0)
        {
            rb.AddForce(
                0,
                0,
                velocidade * -1f,
                tipoDeForca
            );
        }
    }

    void FixedUpdate()
    {
        grounded = Physics.Raycast(transform.position, Vector3.down, 0.8f);
    }
}

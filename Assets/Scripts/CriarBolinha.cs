using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CriarBolinha : MonoBehaviour
{
    public GameObject bolinha;

    void Update()
    {
        if(Input.GetKey("space"))
        {
            float x = Random.Range(-4F, 4F);
            float z = Random.Range(-4F, 4F);
            GameObject bolinhaRecemCriada;

            bolinhaRecemCriada = Instantiate(
                bolinha,
                new Vector3(x, 5, z),
                Quaternion.identity
            );

            Color novaCor = new Color(Random.Range(0f, 1F),
                                      Random.Range(0f, 1F),
                                      Random.Range(0f, 1F));

            bolinhaRecemCriada.GetComponent<Renderer>().material.color = novaCor;            
        }
    }
}

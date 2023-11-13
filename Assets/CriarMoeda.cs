using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CriarMoeda : MonoBehaviour
{
    public GameObject moeda;
    
    void Start()
    {
        float x = Random.Range(-4F, 4F);
        float z = Random.Range(-4F, 4F);
        GameObject moedaRecemCriada;

        moedaRecemCriada = Instantiate(
            moeda,
            new Vector3(x, 0.5f, z),
            Quaternion.identity
        );
    }

}

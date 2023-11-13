using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Moeda : MonoBehaviour
{
    public GameObject moeda;
    private bool estaMorrendo;

    public void OnTriggerEnter(Collider oQueEntrou)
    {
        if(oQueEntrou.tag.Equals("Player"))
        {
            float x = Random.Range(-4F, 4F);
            float z = Random.Range(-4F, 4F);
            GameObject moedaRecemCriada;

            moedaRecemCriada = Instantiate(
                moeda,
                new Vector3(x, 0.5f, z),
                Quaternion.identity
            );
            estaMorrendo = true;

            Destroy(gameObject, 1);
        }
    }

    void Update()
    {
        if (estaMorrendo)
        {
            transform.localScale = new Vector3(
                transform.localScale.x * 0.99f,
                transform.localScale.y * 0.99f,
                transform.localScale.z * 0.99f
                );
        }
    }
}

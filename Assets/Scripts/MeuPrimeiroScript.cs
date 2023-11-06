using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MeuPrimeiroScript : MonoBehaviour
{
    public GameObject objetoQueVaiMorrer;

    public void OnMouseUp()
    {
        Destroy(objetoQueVaiMorrer);
    }
}

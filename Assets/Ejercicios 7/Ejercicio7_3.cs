using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ejercicio7_3 : MonoBehaviour
{
    int contador = 100;
    void Start()
    {
        while (contador > 0)
        {
            Debug.Log(contador);
            contador--;
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}

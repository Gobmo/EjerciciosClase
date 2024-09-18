using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ejercicio7_1 : MonoBehaviour
{
    int contador = 1;
    // Start is called before the first frame update
    void Start()
    {
        while (contador <= 100)
        {
            Debug.Log(contador);
            contador++;
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}

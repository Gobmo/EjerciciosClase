using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ejercicio8_6 : MonoBehaviour
{
    int[] array = new int[20];
    int contador = 0, numero = 2;
    bool activo = true;
    void Start()
    {
        array[19] = 0;
        while (activo)
        {
            if (numero % 2 == 0)
            {
                array[contador] = numero;
                contador++;
            }
            numero++;
            if (array[19] != 0)
            {
                activo = false;
            }
        }
        for (int i = 1; i < array.Length; i++)
        {
            array [0] += array[i];
        }
        Debug.Log("Suma: " + array[0]);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}

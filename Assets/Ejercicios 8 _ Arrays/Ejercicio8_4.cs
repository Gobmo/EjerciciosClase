using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ejercicio8_4 : MonoBehaviour
{
    int[] numeros = new int[5];
    float media = 0;
    // Start is called before the first frame update
    void Start()
    {
        numeros[0] = 3;
        numeros[1] = 7;
        numeros[2] = 20;
        numeros[3] = 1;
        numeros[4] = -10;

        for (int i = 0; i < numeros.Length; i++)
        {
            media += numeros[i];
        }
        media /= numeros.Length;
        Debug.Log("Media: " + media);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}

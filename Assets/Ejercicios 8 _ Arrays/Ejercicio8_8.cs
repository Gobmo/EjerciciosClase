using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ejercicio8_8 : MonoBehaviour
{
    int[] array = new int[10];
    int numNumerosPositivos = 0, numNumerosNegativos = 0;
    float mediaPositiva = 0.00f, mediaNegativa = 0.00f;
    // Start is called before the first frame update
    void Start()
    {
        for (int i = 0; i < array.Length; i++)
        {
            array[i] = Random.Range(-9, 10);
            if (array[i] > 0)
            {
                mediaPositiva += array[i];
                numNumerosPositivos++;
            }
            else if (array[i] < 0)
            {
                mediaNegativa += array[i];
                numNumerosNegativos++;
            }
        }
        mediaPositiva /= numNumerosPositivos;
        mediaNegativa /= numNumerosNegativos;
        Debug.Log("Media de valores positivos: " + mediaPositiva + "\nMedia de valores negativos: " + mediaNegativa);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}

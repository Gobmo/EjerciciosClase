using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ejercicio8_7 : MonoBehaviour
{
    int[] array = new int[10];
    int positivos = 0, negativos = 0;
    // Start is called before the first frame update
    void Start()
    {
        for (int i = 0; i < array.Length; i++)
        {
            array[i] = Random.Range(-15, 16);
            if (array[i] >= 0)
            {
                positivos++;
            }
            else
            {
                negativos++;
            }
        }
        Debug.Log("Números positivos: " + positivos + "\nNúmeros negativos: " + negativos);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}

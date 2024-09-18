using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ejercicio7_12 : MonoBehaviour
{
    
    void Start()
    {
        int resultado = SumarTodosLosNumeros(2, 10);
        Debug.Log(resultado);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    int SumarTodosLosNumeros (int num1, int num2)
    {
        int suma = 0;
        while (num1 <= num2)
        {
            suma += num1;
            num1++;
        }
        return suma;
    }
}

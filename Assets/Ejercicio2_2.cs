using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ejercicio2_2 : MonoBehaviour
{
    int vidas = 0;
    float exp = 0.00f;
    char carac = ' ';
    // Start is called before the first frame update
    void Start()
    {
        vidas = 3;
        exp = 4.53f;
        carac = 'S';
        Debug.Log("Vidas: " + vidas + "\n Exp: " + exp);
        float resultadoSuma = 0.00f;
        resultadoSuma = vidas + exp;
        float resultadoResta = 0.00f;
        resultadoResta = exp - vidas;
        Debug.Log("Resultado suma: " + resultadoSuma + "\nResultado resta: " + resultadoResta);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}

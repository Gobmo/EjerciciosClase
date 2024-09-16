using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ejercicio4_5 : MonoBehaviour
{
    float calculoConversion, monedas;
    void Start()
    {
        monedas = (Ejercicio4_1.aCirculo + Ejercicio4_1.aCuadrado + Ejercicio4_1.aTriangulo) * 0.5f;
        string ConversionFinal = Convertir(monedas, "Dólares");
        Debug.Log(ConversionFinal);
    }

    // Update is called once per frame
    void Update()
    {

    }

    string Convertir(float cantidad, string moneda)
    {
        string resultado;
        if (moneda == "Dólares")
        {
            calculoConversion = cantidad * 0.90f;
        }
        else if (moneda == "Euros")
        {
            calculoConversion = cantidad * 1.11f;
        }
        resultado = calculoConversion + " " + moneda;
        return resultado;
    }
}

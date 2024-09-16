using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ejercicio4_3 : MonoBehaviour
{
    float calculoConversion;
    // Start is called before the first frame update
    void Start()
    {
        string ConversionFinal = Conversion(3, "Dólares");
        Debug.Log(ConversionFinal);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    string Conversion(int cantidad, string moneda)
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

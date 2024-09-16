using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ejercicio4_4 : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        float resultado = ConversionVelocidad(21.43f);
        Debug.Log(resultado + " m/s");
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    float ConversionVelocidad(float velocidad)
    {
        float calculoConversion = (velocidad * 1000) / 3600;
        return calculoConversion;
    }
}

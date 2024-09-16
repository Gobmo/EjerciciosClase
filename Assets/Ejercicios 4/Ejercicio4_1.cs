using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ejercicio4_1 : MonoBehaviour
{
    //Estas variables son utilizadas en el ejercicio 4.5:
    public static float aCirculo = 0.00f;
    public static float aTriangulo = 0.00f;
    public static float aCuadrado = 0.00f;

    void Start()
    {
        float areaFinalCirculo = CalcularAreaCirculo(2.37f);
        Debug.Log("Círculo: " + areaFinalCirculo);

        float areaFinalTriangulo = CalcularAreaTriangulo(1.53f, 3.59f);
        Debug.Log("Triángulo: " + areaFinalTriangulo);

        float areaFinalCuadrado = CalcularAreaCuadrado(9.55f);
        Debug.Log("Cuadrado: " + areaFinalCuadrado);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    
    float CalcularAreaCirculo(float radio)
    {
        float areaCirculo;
        areaCirculo = radio * radio * 3.14f;
        return areaCirculo;
    }

    float CalcularAreaTriangulo(float basse, float altura)
    {
        float areaTriangulo;
        areaTriangulo = (basse * altura) / 2;
        return areaTriangulo;
    }

    float CalcularAreaCuadrado(float lado)
    {
        float areaCuadrado;
        areaCuadrado = lado * lado;
        return areaCuadrado;
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ejercicio2_6 : MonoBehaviour
{
    int puntuacion1 = 1, puntuacion2 = 2, puntuacion3 = 4;
    float resultado = 0;
    // Start is called before the first frame update
    void Start()
    {
        resultado = (puntuacion1 + puntuacion2 + puntuacion3) / 3;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}

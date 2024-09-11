using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ejercicio2_3 : MonoBehaviour
{
    int vidas = 10;
    float exp = 3.5f;
    public float[] operaciones = new float[5];
    // Start is called before the first frame update
    void Start()
    {
        operaciones[0] = vidas * exp;
        operaciones[1] = vidas / exp;
        operaciones[2] = vidas % exp;
        operaciones[3] = vidas * 2;
        operaciones[4] = exp * 3;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}

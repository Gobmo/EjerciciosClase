using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ejercicio7_11 : MonoBehaviour
{
    int numero = 2;
    // Start is called before the first frame update
    void Start()
    {
        for (int i = 0; i < 11; i++)
        {
            Debug.Log(numero + " x " + i + " = " + numero * i);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}

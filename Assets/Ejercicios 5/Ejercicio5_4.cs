using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ejercicio5_4 : MonoBehaviour
{
    [SerializeField] int num1, num2;
    float operacion = 0.00f;
    // Start is called before the first frame update
    void Start()
    {
        if (num2 != 0)
        {
            operacion = num1 / num2;
            Debug.Log(num1 + " / " + num2 + " = " + operacion);
        }
        else
        {
            Debug.Log("El divisor no puede ser 0");
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ejercicio7_13 : MonoBehaviour
{
    bool numeroPrimo = true;
    int contador = 0;
    // Start is called before the first frame update
    void Start()
    {
        ComprobacionNumeroPrimo(17);
        Debug.Log(numeroPrimo);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void ComprobacionNumeroPrimo(int numero)
    {
        if (numero >= 1)
        {
            contador = 2;
            while (contador <= numero)
            {
                if (numero % contador == 0 && numero!=contador)
                {
                    numeroPrimo = false;
                }
                contador++;
            }
        }
        else if (numero < 1)
        {
            contador = -2;
            while (contador >= numero)
            {
                if (numero % contador == 0 && numero!=contador)
                {
                    numeroPrimo = false;
                } 
                contador--;
            }
        }

    }
}

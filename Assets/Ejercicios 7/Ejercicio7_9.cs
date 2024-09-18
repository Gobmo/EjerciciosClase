using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ejercicio7_9 : MonoBehaviour
{
    [SerializeField] int numero;
    int contador = 1;
    // Start is called before the first frame update
    void Start()
    {
        if (numero > contador)
        {
            while (numero >= contador)
            {
                if (contador % 3 == 0)
                {
                    Debug.Log(contador);
                }
                contador++;
            }
        }
        else if (contador > numero)
        {
            while (numero <= contador)
            {
                if (contador % 3 == 0)
                {
                    Debug.Log(contador);
                }
                contador--;
            }
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}

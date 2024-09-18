using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ejercicio7_5 : MonoBehaviour
{
    [SerializeField] int numero;
    int contador = 1;
    // Start is called before the first frame update
    void Start()
    {
        if (numero > 0)
        {
            while (contador <= numero)
            {
                Debug.Log(contador);
                contador++;
            }
            for (int i = 1; i <= numero; i++)
            {
                Debug.Log (i);
            }
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ejercicio7_6 : MonoBehaviour
{
    [SerializeField] int numero;
    int contador = 0;
    // Start is called before the first frame update
    void Start()
    {
        if (numero > 0)
        {
            contador = -numero;
            while (numero >= contador)
            {
                Debug.Log(numero);
                numero--;
            }
            numero = -contador;
            for(int i = numero; i >= contador; i--)
            {
                Debug.Log(i);
            }
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}

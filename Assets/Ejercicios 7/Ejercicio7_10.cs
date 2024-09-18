using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ejercicio7_10 : MonoBehaviour
{
    [SerializeField] int numero1, numero2;
    // Start is called before the first frame update
    void Start()
    {
        if( numero1 < numero2)
        {
            while(numero1 <= numero2)
            {
                string frase = "";
                frase += numero1;
                if (numero1 >= 0)
                {
                    frase += ", positivo";
                }
                else
                {
                    frase += ", negativo";
                }
                if (numero1 %2 == 0)
                {
                    frase += ", par";
                }
                else
                {
                    frase += ", impar";
                }
                Debug.Log(frase);
                numero1++;
            }
        }
        else if (numero1 >= numero2)
        {
            while (numero1 >= numero2)
            {
                string frase = "";
                frase += numero2;
                if (numero2 >= 0)
                {
                    frase += ", positivo";
                }
                else
                {
                    frase += ", negativo";
                }
                if (numero2 % 2 == 0)
                {
                    frase += ", par";
                }
                else
                {
                    frase += ", impar";
                }
                Debug.Log(frase);
                numero2++;
            }
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}

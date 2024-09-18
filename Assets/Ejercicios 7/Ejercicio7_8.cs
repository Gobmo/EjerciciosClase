using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ejercicio7_8 : MonoBehaviour
{
    [SerializeField] int numero1, numero2;
    // Start is called before the first frame update
    void Start()
    {
        if (numero1 < numero2)
        {
            while (numero1 <= numero2)
            {
                if (numero1 % 2 == 0)
                {
                    Debug.Log(numero1);
                }
                numero1++; 
            }
        }
        else if (numero1 > numero2)
        {
            while (numero1 >= numero2)
            {
                if (numero2 % 2 == 0)
                {
                    Debug.Log(numero2);
                }
                numero2++;
            }
        }
        else
        {
            Debug.Log("Los 2 números son iguales");
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}

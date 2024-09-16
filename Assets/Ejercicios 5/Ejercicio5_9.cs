using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ejercicio5_9 : MonoBehaviour
{
    [SerializeField] int tipo;
    int danio = 0, vida = 0;
    void Start()
    {
        if (tipo == 1)
        {
            danio = 350;
            vida = 650;
        }
        else if (tipo == 2)
        {
            danio = 300;
            vida = 550;
        }
        else if (tipo == 3)
        {
            danio = 300;
            vida = 500;
        }
        else if (tipo == 4)
        {
            danio = 310;
            vida = 460;
        }
        else if (tipo == 5)
        {
            danio = 280;
            vida = 490;
        }
        else if (tipo == 6)
        {
            danio = 360;
            vida = 520;
        }
        Debug.Log("Daño: " + danio + "\nVida: " + vida);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}

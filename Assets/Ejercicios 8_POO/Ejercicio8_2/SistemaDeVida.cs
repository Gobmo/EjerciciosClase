using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SistemaDeVida : MonoBehaviour
{
    [SerializeField] float vidaInicial;
    float vidaActual = 0;
    // Start is called before the first frame update
    void Start()
    {
        vidaActual = vidaInicial;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public float RecibirCura(float cantidad)
    {
        if (cantidad >= 0)
        {
            vidaActual += cantidad;
            return vidaActual; 
        }
        else
        {
            return -1;
        }
    }
    float RecibirDanho(float danho)
    {
        if (danho >= 0 && danho <= vidaActual)
        {
            vidaActual -= danho;
            return vidaActual; 
        }
        else if (danho >= 0 && danho > vidaActual)
        {
            return 0;
        }
        else
        {
            return -1;
        }
    }
}

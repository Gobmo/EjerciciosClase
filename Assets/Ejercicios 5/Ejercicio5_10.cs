using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ejercicio5_10 : MonoBehaviour
{
    [SerializeField] float temperatura;
    void Start()
    {
        if (temperatura <= 10)
        {
            Debug.Log("Se encuentra en un clima frío");
        }
        else if (temperatura <= 20)
        {
            Debug.Log("Se encuentra en un clima Nublado");
        }
        else if (temperatura <= 30)
        {
            Debug.Log("Se encuentra en un clima caluroso");
        }
        else if (temperatura > 30)
        {
            Debug.Log("Se encuentra en un clima tropical");
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}

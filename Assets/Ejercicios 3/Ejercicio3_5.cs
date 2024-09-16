using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ejercicio3_5 : MonoBehaviour
{
    [SerializeField] float radio;
    float longitud = 0.00f, area = 0.00f;
    // Start is called before the first frame update
    void Start()
    {
        longitud = 2 * 3.14f * radio;
        area = 3.14f * (radio * radio);
        Debug.Log("Área: " + area + "\nLongitud: " + longitud);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ejercicio4_2 : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        string nombreCompleto = CalcularNombre("Paco", "Pueblas", "Linossa", "15 años");
        Debug.Log(nombreCompleto);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    string CalcularNombre(string nombre, string apellido1, string apellido2, string edad)
    {
        string sumaNombres;
        sumaNombres = "El usuario " + nombre + " " + apellido1 + " " + apellido2 + ", con " + edad + " años de edad, es el culpable.";
        return sumaNombres;
    }
}

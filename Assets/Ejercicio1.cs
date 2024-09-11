using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ejercicio1 : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("¡Hola Mundo!" + "\n Este es el primer videojuego de Sergio");
        Debug.Log("Estoy aprendiendo C#");
    }

    // Update is called once per frame
    void Update()
    {
        Debug.Log("Ha pasado un frame"); //¿Por qué aparece tantas veces por consola este último mensaje al dar al Play?
    }
}

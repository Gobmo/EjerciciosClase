using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ejercicio8_5 : MonoBehaviour
{
    int[] dificultad = new int[4];
    string[] nombre = new string[4];
    // Start is called before the first frame update
    void Start()
    {
        dificultad[0] = 10;
        dificultad[1] = 10;
        dificultad[2] = 20;
        dificultad[3] = 30;

        nombre[0] = "Aaaa";
        nombre[1] = "Bbbb";
        nombre[2] = "Cccc";
        nombre[3] = "Dddd";

        for (int i = 0; i < dificultad.Length; i++)
        {
            Debug.Log("El nivel número " + i + " llamado " + nombre[i] + " tiene una dificultad de " + dificultad[i]);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}

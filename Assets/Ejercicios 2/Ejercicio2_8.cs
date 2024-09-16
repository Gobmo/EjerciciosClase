using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ejercicio2_8 : MonoBehaviour
{
    float vidaInicial = 120, vida = 120;
    // Start is called before the first frame update
    void Start()
    {
        vida -= (vida * 3) / 100;
        Debug.Log("Vida: " + vida);
        vida -= (vidaInicial * 6) / 100;
        Debug.Log("Vida: " + vida);
        vida -= (vidaInicial * 9) / 100;
        Debug.Log("Vida: " + vida);
        vida -= (vidaInicial * 12) / 100;
        Debug.Log("Vida: " + vida);
        vida -= (vidaInicial * 15) / 100;
        Debug.Log("Vida: " + vida);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}

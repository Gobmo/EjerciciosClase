using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ejercicio2_5 : MonoBehaviour
{
    int vidasPlayer1 = 1, vidasPlayer2 = 2, vidasPlayer3 = 3, vidasPlayer4 = 4, vidasPlayer2Iniciales = 0;
    // Start is called before the first frame update
    void Start()
    {
        vidasPlayer2Iniciales = vidasPlayer2;
        vidasPlayer2 = vidasPlayer3;
        vidasPlayer3 = vidasPlayer1;
        vidasPlayer1 = vidasPlayer4;
        vidasPlayer4 = vidasPlayer2Iniciales;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}

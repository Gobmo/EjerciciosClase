using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Personaje : MonoBehaviour
{
    private string nombre;
    private int vida, experiencia = 130304;
    bool miTurno = false;

    public string Nombre { get => nombre; set => nombre = value; }
    public int Vida { get => vida; set => vida = value; }
    public bool MiTurno { get => miTurno; set => miTurno = value; }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public float CalcularNivel()
    {
        float nivel = experiencia / 1000;
        return nivel;
    }
}

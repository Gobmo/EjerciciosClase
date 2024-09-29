using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Personaje3 : MonoBehaviour
{
    float ataque, velocidad, vida;
    Personaje3 objetive;

    public float Vida { get => vida; set => vida = value; }
    public float Velocidad { get => velocidad;}

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void RellenarStats(float atq, float vel, float hp)
    {
        ataque = atq; 
        velocidad = vel; 
        vida = hp;
    }
    public void MarcarObjetivo(Personaje3 objetivo)
    {
        objetive = objetivo;
    }
    public void Atacar()
    {
        objetive.vida -= ataque;
    }
}

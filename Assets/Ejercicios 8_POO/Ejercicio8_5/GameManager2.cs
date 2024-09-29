using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager2 : MonoBehaviour
{
    bool yaEjecutado = false;
    float nivel = 0.00f;
    Personaje2 personaje2;
    [SerializeField] Personaje personaje;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape) && yaEjecutado == false)
        {
            PrepararPersonajes();
        }
    }

    void PrepararPersonajes()
    {
        personaje.Nombre = "Caillou";
        personaje.Vida = 10;
        nivel = personaje.CalcularNivel();
        Debug.Log("Nivel: " + nivel);
        yaEjecutado = true;
    }

    public bool FinDeTurno(bool turno)
    {
        if (turno == true)
        {
            personaje2.MiTurno = false;
            personaje.MiTurno = true;
            return true;
        }
        else
        {
            return false; 
        }
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    bool yaEjecutado = false;
    float nivel = 0.00f;
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
}

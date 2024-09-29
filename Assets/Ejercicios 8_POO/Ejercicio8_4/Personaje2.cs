using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Personaje2 : MonoBehaviour
{
    private string nombre;
    private int vida, experiencia = 130304;

    Personaje enemigo;
    Arma arma;
    SistemaDeVida miSistemaDeVidas;
    GameManager2 gameManager;
    [SerializeField]KeyCode teclaCurar, teclaAtacar, teclaRecargar;

    bool miTurno = true;

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
        if (Input.GetKeyDown(teclaCurar) && miTurno)
        {
            miSistemaDeVidas.RecibirCura(1);
            gameManager.FinDeTurno(miTurno);
        }
        if (Input.GetKeyDown(teclaAtacar) && miTurno)
        {
            int resultado = arma.UtilizarArma();
            if (resultado == 0)
            {
                AtacarAEnemigo(Random.Range(arma.DanhoMinimo, (arma.DanhoMaximo + 1))); 
            }
            else if (resultado == -1)
            {
                Debug.Log("Reload!!!");
            }
            gameManager.FinDeTurno(miTurno);
        }
        if (Input.GetKeyDown(teclaRecargar) && miTurno)
        {
            int resultado = arma.RecargarArma();
            if (resultado == -1)
            {
                Debug.Log("Arma ya cargada");
            }
            gameManager.FinDeTurno(miTurno);
        }
    }

    public float CalcularNivel()
    {
        float nivel = experiencia / 1000;
        return nivel;
    }

    void AtacarAEnemigo(int danho)
    {
        enemigo.Vida -= danho;
    }
}

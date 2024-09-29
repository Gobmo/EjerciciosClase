using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Batalla : MonoBehaviour
{
    Personaje3 player1, player2, player3, player4, combatiente1, combatiente2;
    int azar1 = 0, azar2 = 0;
    bool realizado = false;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void GenerarCombatientes()
    {
        player1.RellenarStats(Random.Range(50, 121), Random.Range(20, 101), Random.Range(50, 201));
        player2.RellenarStats(Random.Range(50, 121), Random.Range(20, 101), Random.Range(50, 201));
        player3.RellenarStats(Random.Range(50, 121), Random.Range(20, 101), Random.Range(50, 201));
        player4.RellenarStats(Random.Range(50, 121), Random.Range(20, 101), Random.Range(50, 201));
    }

    void CrearEmparejamieto()
    {
        azar1 = Random.Range(1, 5);
        if (azar1 == 1)
        {
            combatiente1 = player1;
        }
        else if (azar1 == 2)
        {
            combatiente1 = player2;
        }
        else if (azar1 == 3)
        {
            combatiente1 = player3;
        }
        else if (azar1 == 4)
        {
            combatiente1 = player4;
        }
        realizado = false;
        while (realizado == false)
        {
            azar2 = Random.Range(1, 5);
            if (azar2 >0 && azar2 != azar1)
            {
                if (azar2 == 1)
                {
                    combatiente2 = player1;
                }
                else if (azar2 == 2)
                {
                    combatiente2 = player2;
                }
                else if (azar2 == 3)
                {
                    combatiente2 = player3;
                }
                else if (azar2 == 4)
                {
                    combatiente2 = player4;
                }
                realizado = true;
            }
        }
        combatiente1.MarcarObjetivo(combatiente2);
        combatiente2.MarcarObjetivo(combatiente1);
    }

    void GenerarCombate()
    {
        if (combatiente1.Vida > 0 && combatiente2.Vida > 0)
        {
            if (combatiente1.Velocidad >= combatiente2.Velocidad)
            {
                Debug.Log("Ataca combatiente 1");
                combatiente1.Atacar();
            }
            else if (combatiente1.Velocidad < combatiente2.Velocidad)
            {
                Debug.Log("Ataca el combatiente 2");
                combatiente1.Atacar();
            } 
        }
        else if (combatiente1.Vida <= 0)
        {
            Debug.Log("El commbatiente 1 ha perdido la vida");
        }
        else if (combatiente2.Vida <= 0)
        {
            Debug.Log("El commbatiente 2 ha perdido la vida");
        }
    }
}

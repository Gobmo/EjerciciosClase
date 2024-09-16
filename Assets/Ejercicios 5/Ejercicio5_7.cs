using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ejercicio5_7 : MonoBehaviour
{
    [SerializeField] int vel1, vel2, vel3;
    void Start()
    {
        if (vel1 > vel2 && vel1 > vel3)
        {

        }
        else if (vel2 > vel3 && vel2 > vel1)
        {

        }
        else if (vel3 > vel1 && vel3 > vel2)
        {

        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}  
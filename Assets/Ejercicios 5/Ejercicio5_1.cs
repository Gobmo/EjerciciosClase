using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ejercicio5_1 : MonoBehaviour
{
    [SerializeField] int vida1, vida2;
    void Start()
    {
        if (vida1 == vida2)
            Debug.Log("Tienen la misma vida");
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ejercicio3_3 : MonoBehaviour
{
    [SerializeField] int num;
    int doble = 0, triple = 0;
    // Start is called before the first frame update
    void Start()
    {
        doble = num * 2;
        triple = num * 3;
        Debug.Log("Doble: " + doble + "\nTriple: " + triple);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}

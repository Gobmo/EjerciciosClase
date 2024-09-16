using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ejercicio5_3 : MonoBehaviour
{
    [SerializeField] int num;
    // Start is called before the first frame update
    void Start()
    {
        if (num >= 0 && num <= 9)
            Debug.Log("El número está comprendido entre 0 y 9");
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}

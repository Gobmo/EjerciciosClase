using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ejercicio3_7 : MonoBehaviour
{
    [SerializeField] float basE, altura;
    float area = 0.00f;
    // Start is called before the first frame update
    void Start()
    {
        area = (basE * altura) / 2;
        Debug.Log("Área: " + area);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}

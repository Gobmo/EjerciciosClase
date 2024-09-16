using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ejercicio5_8 : MonoBehaviour
{
    [SerializeField] int h, m, s;
    void Start()
    {
        if ((h >= 0 && h < 24) && (m >= 0 && m < 60) && (s >= 0 && s < 60))
        {
            Debug.Log("Hora: " + h + ":" + m + ":" + s);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ejercicio8_2 : MonoBehaviour
{
    int[] array = new int[10];
    void Start()
    {
        for (int i = 0; i < array.Length; i++)
        {
            array[i] = Random.Range(1, 11);
            Debug.Log("La caja con índice " + i + " contiene el número " + array[i]);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}

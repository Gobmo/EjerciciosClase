using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ejercicio8_3 : MonoBehaviour
{
    int[] array = new int[500];
    // Start is called before the first frame update
    void Start()
    {
        for (int i = 0; i < array.Length; i++)
        {
            array[i] = Random.Range(-50, 721);
            Debug.Log(array[i]);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ejercicio3_6 : MonoBehaviour
{
    [SerializeField] float kmXh = 0.00f;
    float mXs = 0.00f;
    // Start is called before the first frame update
    void Start()
    {
        mXs = kmXh * 1000 / 3600;
        Debug.Log(mXs + " m/s");
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}

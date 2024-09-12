using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ejercicio3_4 : MonoBehaviour
{
    [SerializeField] int exp;
    int lvl = 0;
    // Start is called before the first frame update
    void Start()
    {
        lvl = 32 + (9 * exp/5);
        Debug.Log("Level: " + lvl);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}

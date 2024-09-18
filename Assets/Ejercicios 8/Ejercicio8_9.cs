using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ejercicio8_9 : MonoBehaviour
{
    int[] alturas = new int[7];
    int superaLaMedia = 0, inferiorAlaMedia= 0;
    float media = 0.00f;
    // Start is called before the first frame update
    void Start()
    {
        alturas[0] = 171;
        alturas[1] = 165;
        alturas[2] = 180;
        alturas[3] = 201;
        alturas[4] = 166;
        alturas[5] = 184;
        alturas[6] = 173;

        for (int i = 0; i < alturas.Length; i++)
        {
            media += alturas[i];
        }
        media /= alturas.Length;

        for (int i = 0;i < alturas.Length;i++)
        {
            if (alturas[i] > media)
            {
                superaLaMedia++;
            }
        }

        inferiorAlaMedia = alturas.Length - superaLaMedia;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}

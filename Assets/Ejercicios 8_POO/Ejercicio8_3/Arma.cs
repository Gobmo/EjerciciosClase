using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Arma : MonoBehaviour
{
    [SerializeField] int danhoMinimo, danhoMaximo, capacidadTotal;
    [SerializeField] bool automatica;
    int municionActual = 0;

    public int DanhoMinimo { get => danhoMinimo;}
    public int DanhoMaximo { get => danhoMaximo;}

    // Start is called before the first frame update
    void Start()
    {
        municionActual = capacidadTotal;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public int UtilizarArma()
    {
        if (municionActual > 0)
        {
            municionActual -= 1;
            return 0;
        }
        else
        {
            return -1;
        }
    }
    public int RecargarArma()
    {
        if (municionActual != capacidadTotal)
        {
            municionActual = capacidadTotal;
            return 0;
        }
        else
        {
            return -1;
        }
    }
}

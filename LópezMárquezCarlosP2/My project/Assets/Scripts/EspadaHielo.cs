using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EspadaHielo : EspadaBase
{
    // Start is called before the first frame update
    void Start()
    {
        SetNombre("Espada de Hielo");
        SetTipo("Hielo");
        SetDa�o(100);
        SetTipoDa�o(50);
        GetInfo();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}

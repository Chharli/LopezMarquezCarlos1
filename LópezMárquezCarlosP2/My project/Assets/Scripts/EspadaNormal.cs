using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EspadaNormal : EspadaBase
{
    // Start is called before the first frame update
    void Start()
    {
        SetNombre("Espada Normal");
        SetTipo("Normal");
        SetDa�o(100);
        SetTipoDa�o(0);
        GetInfo();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}

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
        SetDaño(100);
        SetTipoDaño(0);
        GetInfo();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}

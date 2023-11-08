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
        SetDaño(100);
        SetTipoDaño(50);
        GetInfo();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}

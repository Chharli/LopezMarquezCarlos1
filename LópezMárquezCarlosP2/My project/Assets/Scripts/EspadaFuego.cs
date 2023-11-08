using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EspadaFuego : EspadaBase
{
    // Start is called before the first frame update
    void Start()
    {
        SetNombre("Espada de Fuego");
        SetTipo("Fuego");
        SetDaño(100);
        SetTipoDaño(50);
        GetInfo();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}

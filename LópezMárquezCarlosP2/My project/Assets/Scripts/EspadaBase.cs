using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EspadaBase : MonoBehaviour
{
    public string Nombre;
    public string Tipo;
    public int Daño;
    public int tipoDaño;

    // Start is called before the first frame update
    public void SetNombre(string nombre)
    {
        Nombre = nombre;
    }
    public void SetTipo(string tipo)
    {
        Tipo = tipo;
    }
    public void SetDaño(int daño)
    {
        Daño = daño;
    }
    public void SetTipoDaño(int tipodaño)
    {
        tipoDaño = tipodaño;
    }
    public void GetInfo()
    {
        Debug.Log("Nombre " + Nombre);
        Debug.Log("Tipo " + Tipo);
        Debug.Log("Daño " + Daño);
        Debug.Log("Tipo " + Tipo);

    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EspadaBase : MonoBehaviour
{
    public string Nombre;
    public string Tipo;
    public int Da�o;
    public int tipoDa�o;

    // Start is called before the first frame update
    public void SetNombre(string nombre)
    {
        Nombre = nombre;
    }
    public void SetTipo(string tipo)
    {
        Tipo = tipo;
    }
    public void SetDa�o(int da�o)
    {
        Da�o = da�o;
    }
    public void SetTipoDa�o(int tipoda�o)
    {
        tipoDa�o = tipoda�o;
    }
    public void GetInfo()
    {
        Debug.Log("Nombre " + Nombre);
        Debug.Log("Tipo " + Tipo);
        Debug.Log("Da�o " + Da�o);
        Debug.Log("Tipo " + Tipo);

    }
}

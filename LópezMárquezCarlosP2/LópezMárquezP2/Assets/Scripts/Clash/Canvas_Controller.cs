using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Canvas_Controller : MonoBehaviour
{
    public Canvas canvas1;
    public Canvas canvas2;
    public Button cambiarCanvasButton;

    void Start()
        {
        canvas1.enabled = true;
        canvas2.enabled = false;

        cambiarCanvasButton.onClick.AddListener(CambiarCanvas);
        }
void CambiarCanvas()
    {
        canvas1.enabled = false;
        canvas2.enabled = true;
    }

    private void Update()
    {
        
    }
}

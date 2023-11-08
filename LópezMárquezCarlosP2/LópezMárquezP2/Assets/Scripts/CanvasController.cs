using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CanvasController : MonoBehaviour
{
    public Canvas canvas1;
    public Canvas canvas2;
    public Canvas ChangeCanvasButton;
    
    void Start()
    {
        canvas1.enabled = true;
        canvas2.enabled = false;
        //ChangeCanvasButton.onClick.AddListener(ChangeCanvas);
    }
    void ChangeCanvas()
    {
        canvas1.enabled = false;
        canvas2.enabled = true;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}

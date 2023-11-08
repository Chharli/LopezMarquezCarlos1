using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ImageSlider : MonoBehaviour
{
    public float speed = 2.0f; // Velocidad de desplazamiento
    public float minY = 0.0f; // Límite inferior
    public float maxY = 5.0f; // Límite superior

    private Vector3 initialPosition;

    private void Start()
    {
        initialPosition = transform.position;
    }

    private void Update()
    {
        float mouseY = Input.GetAxis("Mouse Y");
        Vector3 newPosition = transform.position + Vector3.up * mouseY * speed * Time.deltaTime;
        newPosition.y = Mathf.Clamp(newPosition.y, minY, maxY);
        transform.position = newPosition;
    }
}

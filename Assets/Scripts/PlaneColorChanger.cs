using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlaneColorChanger : MonoBehaviour
{
    private Color planeColor; // Plane'in orijinal rengini saklamak i�in

    private void Start()
    {
        // Plane'in orijinal rengini al
        Renderer planeRenderer = GetComponent<Renderer>();
        if (planeRenderer != null)
        {
            planeColor = planeRenderer.material.color;
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Cylinder")) // E�er temas eden obje "Player" etiketine sahipse
        {
            Renderer playerRenderer = other.GetComponent<Renderer>();
            if (playerRenderer != null)
            {
                // Karakterin rengini Plane'in orijinal rengiyle de�i�tir
                playerRenderer.material.color = planeColor;
            }
        }
    }
}

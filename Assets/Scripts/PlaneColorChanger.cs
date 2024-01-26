using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlaneColorChanger : MonoBehaviour
{
    [SerializeField] private Color planeColor; 

    private void Start()
    {
        
        Renderer planeRenderer = GetComponent<Renderer>();
        if (planeRenderer != null)
        {
            planeColor = planeRenderer.material.color;
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Cylinder")) 
        {
            Renderer playerRenderer = other.GetComponent<Renderer>();
            if (playerRenderer != null)
            {
                
                playerRenderer.material.color = planeColor;
            }
        }
    }
}

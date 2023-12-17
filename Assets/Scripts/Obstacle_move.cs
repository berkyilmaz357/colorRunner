using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Obstacle_move : MonoBehaviour
{
    public float rotationSpeed = 5f; // Dönme hýzý

    void Update()
    {
        // Objeyi kendi ekseni etrafýnda döndür
        transform.Rotate(Vector3.up, rotationSpeed * Time.deltaTime);
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Obstacle_move : MonoBehaviour
{
    public float rotationSpeed = 5f; // D�nme h�z�

    void Update()
    {
        // Objeyi kendi ekseni etraf�nda d�nd�r
        transform.Rotate(Vector3.up, rotationSpeed * Time.deltaTime);
    }
}

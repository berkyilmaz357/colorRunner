using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SlowDownZone : MonoBehaviour
{
    [SerializeField] private float normalSpeed = 3f;
    [SerializeField] private float slowedSpeed = 1f;

    private bool isInSlowZone = false;
    private Rigidbody rb;

    void Start()
    {
        rb = GetComponent<Rigidbody>();
        SetSpeed(normalSpeed);
    }

    void Update()
    {
        // Karakter hareket kodlarý buraya eklenebilir
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("SlowBox"))
        {
            isInSlowZone = true;
            SetSpeed(slowedSpeed);
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("SlowBox"))
        {
            isInSlowZone = false;
            SetSpeed(normalSpeed);
        }
    }

    void SetSpeed(float speed)
    {
        rb.velocity = new Vector3(0, 0, speed);
    }
}
    
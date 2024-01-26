using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    // Start is called before the first frame update
    [Header("Speed Variables")]
    [SerializeField] private float runSpeed = 3f;
    [SerializeField] private float changeLaneSpeed = 3;
    [SerializeField] private float slowedSpeed = 1f;
    [SerializeField] private float normalSpeed = 3f;
    private bool isInBox = false;
    void Start()
    {
        //Start running
        SetSpeed(normalSpeed);


    }

    // Update is called once per frame
   
    
        void Update()
        {
            // A tuþuna basýldýðýnda sola hareket
            if (Input.GetKey("a"))
            {
                transform.Translate((Time.deltaTime * -changeLaneSpeed), 0, 0);
            }

            // D tuþuna basýldýðýnda saða hareket
            if (Input.GetKey("d"))
            {
                transform.Translate((Time.deltaTime * changeLaneSpeed), 0, 0);
            }
        }

    public void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("SlowBox"))
        {
            isInBox = true;
            SetSpeed(slowedSpeed);
        }
    }

    public void OnTriggerExit(Collider other)
    {
        if(other.CompareTag("SlowBox"))
        {
            isInBox = false;
            SetSpeed(normalSpeed);
        }
    }
    void SetSpeed(float speed)
    {
        if (isInBox)
        {
            GetComponent<Rigidbody>().velocity = new Vector3(0, 0, runSpeed);


        }
        else
        {
            GetComponent<Rigidbody>().velocity = new Vector3(0, 0, runSpeed);
        }




    }



}

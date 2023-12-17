using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    // Start is called before the first frame update
    [Header("Speed Variables")]
    [SerializeField] private float runSpeed = 3;
    [SerializeField] private float changeLaneSpeed = 3;
    void Start()
    {
        //Start running
        GetComponent<Rigidbody>().velocity = new Vector3(0, 0, runSpeed);


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


    }

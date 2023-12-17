using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterSpawner : MonoBehaviour
{
    [SerializeField] Transform Player;
    float objectHeight = 4f;
    float stackCount = 0;

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Cylinder"))
        {
            Transform t = other.transform;
            gameObject.tag = "unCylinder";
            t.SetParent(this.transform);
            t.localPosition = new Vector3(0, 0, -stackCount * objectHeight);

            stackCount++;

        }
        else if (other.CompareTag("enemyCyl"))
        {
            stackCount--;
            stackCount = Mathf.Max(stackCount, 0);

            Destroy(other.gameObject);

            

            Destroy(gameObject);


        }
    
    
    
    }

}
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterSpawner : MonoBehaviour
{
    [SerializeField] Transform Player;
    float objectHeight = 4f;
    float stackCount = 0;

    // Spike engelinin her biri için sildi mi kontrolü
    Dictionary<GameObject, bool> spikeStates = new Dictionary<GameObject, bool>();

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
        else if (other.CompareTag("Spike"))
        {
            // Spike daha önce silinmediyse en son eklenen silindiri sil
            if (!spikeStates.ContainsKey(other.gameObject) || !spikeStates[other.gameObject])
            {
                RemoveLastCylinder();
                spikeStates[other.gameObject] = true; // Spike bir kez sildi
            }
        }
    }

    void RemoveLastCylinder()
    {
        // Son eklenen silindiri bul ve sil
        Transform lastCylinder = transform.GetChild(transform.childCount - 1);
        if (lastCylinder != null)
        {
            Destroy(lastCylinder.gameObject);
            stackCount--; // Silindiði için stackCount'u düþür
            stackCount = Mathf.Max(stackCount, 0);
        }
    }

    // Karakter spike engelinden çýktýðýnda spike'ýn durumunu sýfýrla
    private void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("Spike") && spikeStates.ContainsKey(other.gameObject))
        {
            spikeStates[other.gameObject] = false;
        }
    }
}

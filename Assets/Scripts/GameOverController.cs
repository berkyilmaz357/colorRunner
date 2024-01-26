using System.Collections;
using System.Collections.Generic;
using UnityEngine;


[SerializeField] public class GameOverController : MonoBehaviour
{
    
    private void OnDestroy()
    {
        if (gameObject.CompareTag("delete"))
        {
            Time.timeScale = 0f;
        }
    }
}

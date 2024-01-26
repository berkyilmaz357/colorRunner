using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameOverController : MonoBehaviour
{
    
    private void OnDestroy()
    {
        if (gameObject.CompareTag("delete"))
        {
            Time.timeScale = 0f;
        }
    }
}

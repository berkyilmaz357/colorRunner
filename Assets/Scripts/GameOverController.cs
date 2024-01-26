using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameOverController : MonoBehaviour
{
    // "delete" tag'ine sahip obje silindišinde oyunu durdur
    private void OnDestroy()
    {
        if (gameObject.CompareTag("delete"))
        {
            Time.timeScale = 0f;
        }
    }
}

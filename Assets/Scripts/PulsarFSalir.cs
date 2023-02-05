using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PulsarFSalir : MonoBehaviour
{
    private int pulsado = 0;
    private void Update()
    {
        if (Input.GetKey(KeyCode.F))
        {
            if (pulsado == 0)
            {
                pulsado += 1;
            }
            else
            {
                SceneManager.LoadScene("INICIO");
            }
        }
    }
}

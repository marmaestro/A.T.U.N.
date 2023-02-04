using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class RickRoll : MonoBehaviour
{
    private const int MAX_IDLE = 25;
    private float ultimoInstanteIdle;

    void Awake()
    {
        ultimoInstanteIdle = Time.time;
    }

    private void Update()
    {
        if (Input.anyKey)
        {
            ultimoInstanteIdle = Time.time;
        }

        ComprobarIdle();
    }

    private void ComprobarIdle()
    {
        if (Time.time - ultimoInstanteIdle > MAX_IDLE)
        {
            SceneManager.LoadScene("TIMEOUT");
        }
    }
}
